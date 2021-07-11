using UnityEngine;

// Scriptable Object 腳本化物件：將腳本以物件方式儲存於 Project 內
// 需要搭配類別屬性 CAM 建立資料選單
// fileName 檔案名稱,menuName 選單名稱 - 可利用 / 設定階層
/// <summary>
/// 採集物件資料
/// </summary>
[CreateAssetMenu(fileName = "採集物件資料", menuName = "作業/採集物件資料")]

public class DataCollection : ScriptableObject
{
    [Header("採集物件血量"), Range(0, 100)]
    public float hp;
    [Header("掉落物")]
    public GameObject objDrop;
}
