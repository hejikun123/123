Shader "Unlit/UL"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _lineWidth("lineWidth",Range(0,10)) = 1
        _lineColor("lineColor",Color)=(1,1,1,1)
    }
    // ---------------------------������ɫ����---------------------------
    SubShader
    {
        // ��Ⱦ���в��� ͸��
        Tags{
            "Queue" = "Transparent"
        }
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            //������ɫ������ṹ�� 
            struct VertexInput
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
            //������ɫ������ṹ�� 
            struct VertexOutput
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            // ---------------------------��������ɫ����---------------------------
            VertexOutput vert (VertexInput v)
            {
                VertexOutput o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;
            float4 _MainTex_TexelSize;
            float _lineWidth;
            float4 _lineColor;

            // ---------------------------��ƬԪ��ɫ����---------------------------
            fixed4 frag (VertexOutput i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                // ������Χ4����
                float2 up_uv = i.uv + float2(0,1) * _lineWidth * _MainTex_TexelSize.xy;
                float2 down_uv = i.uv + float2(0,-1) * _lineWidth * _MainTex_TexelSize.xy;
                float2 left_uv = i.uv + float2(-1,0) * _lineWidth * _MainTex_TexelSize.xy;
                float2 right_uv = i.uv + float2(1,0) * _lineWidth * _MainTex_TexelSize.xy;
                // �����һ����͸����Ϊ0 ˵���Ǳ�Ե
                float w = tex2D(_MainTex,up_uv).a * tex2D(_MainTex,down_uv).a * tex2D(_MainTex,left_uv).a * tex2D(_MainTex,right_uv).a;

                 //if(w == 0){
                     //  col.rgba = _lineColor;
                // }
                // ��ԭͼ����ֵ
                col.rgb = lerp(_lineColor,col.rgba,w);
                return col;
            }
            ENDCG
        }
    }

}
