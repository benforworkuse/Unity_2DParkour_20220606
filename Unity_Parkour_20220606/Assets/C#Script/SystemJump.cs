using UnityEngine;
/// <summary>
/// ���D�t��
/// </summary>
namespace Ben
{

    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Tooltip("���D����"), Range(0, 3000)]
        private float JumpHeight = 350;
        private Rigidbody2D rig;
        private Animator CharacterCtl;
        private bool clickJump = false;
        #endregion
        #region �\��

        void jumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = true;
                print("���D!");
            }
        }
        void jump()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, JumpHeight));
                clickJump = false;
            }
        }
        #endregion
        #region �ƥ�
        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            CharacterCtl = GetComponent<Animator>();
        }
        private void Update()
        {
            jumpKey();
        }
        private void FixedUpdate()
        {
            jump();

        }
        #endregion
    }
}