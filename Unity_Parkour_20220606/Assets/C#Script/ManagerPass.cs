
using UnityEngine;

/// <summary>
/// �g�q���P�_
/// </summary>

namespace Ben
{
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")] private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�]�B�t��")] private SystemRun systemRun;
        [SerializeField, Header("���D�t��")] private SystemJump systemJump;
        [SerializeField, Header("�������")] private ManageFinal manageFinal;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;
                systemJump.enabled = false;
                manageFinal.enabled = true;
                manageFinal.stringTitle = "���߹L��!";
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

