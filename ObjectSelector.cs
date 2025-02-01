using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public CameraFollowSelectedObject cameraFollowScript;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 检测是否点击到 UI 元素
            if (EventSystem.current.IsPointerOverGameObject()) return;

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // 获取被点击物体的 Transform 组件
                Transform selected = hit.transform;
                // 调用摄像机跟随脚本的方法设置选中物体
                CameraFollowScript.SetSelectedObject(selected);
            }
        }
    }
}
