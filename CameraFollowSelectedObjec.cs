using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSelectedObjec : MonoBehaviour
{
    public Transform selectedObject; // 被选中的物体
    public float smoothSpeed = 0.125f; // 摄像机跟随的平滑速度
    public Vector3 offset = new Vector3(0, 3, -5);  // 摄像机与被选中物体的偏移量

    void FixedUpdate()
    {
        if (selectedObject != null)
        {
            // 计算期望的摄像机位置
            Vector3 desiredPosition = selectedObject.position + offset;
            // 使用 Vector3.Lerp 实现平滑跟随
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // 设置摄像机的位置
            transform.position = smoothedPosition;

            // 让摄像机看向被选中的物体
            transform.LookAt(selectedObject);
        }
    }

    // 用于在外部设置选中的物体
    public void SetSelectedObject(Transform newSelectedObject)
    {
        selectedObject = newSelectedObject;
    }
}
