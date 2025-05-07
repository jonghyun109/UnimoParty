using UnityEngine;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine.UI; // Text용
// using TMPro; // ← TextMeshProUGUI 쓸 경우 주석 해제

public class MetaUserIDDisplay : MonoBehaviour
{
    public Text userIdText; // TextMeshProUGUI userIdText; ← TextMeshPro 쓸 경우 변경

    void Start()
    {
        Core.Initialize();

        Entitlements.IsUserEntitledToApplication().OnComplete(OnEntitlementCheck);
    }

    void OnEntitlementCheck(Message msg)
    {
        if (msg.IsError)
        {
            Debug.LogError("권한 없음. 종료.");
        }
        else
        {
            Users.GetLoggedInUser().OnComplete(OnUserGet);
        }
    }

    void OnUserGet(Message<User> msg)
    {
        if (msg.IsError)
        {
            Debug.LogError("유저 정보 가져오기 실패");
        }
        else
        {
            string id = msg.Data.ID.ToString();
            Debug.Log("유저 ID: " + id);
            userIdText.text = "User ID: " + id;
        }
    }
}