
using UnityEngine;

/// <summary>
/// 寫通關與否
/// </summary>

namespace Ben
{
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")] private string nameTarget = "忍者龜";
        [SerializeField, Header("跑步系統")] private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")] private SystemJump systemJump;
        [SerializeField, Header("結束控制器")] private ManageFinal manageFinal;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;
                systemJump.enabled = false;
                manageFinal.enabled = true;
                manageFinal.stringTitle = "恭喜過關!";
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
    }
}

