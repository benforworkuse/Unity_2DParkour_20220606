using UnityEngine;
/// <summary>
/// 跳躍系統
/// </summary>
namespace Ben
{

    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Tooltip("跳躍高度"), Range(0, 3000)]
        private float JumpHeight = 350;
        private Rigidbody2D rig;
        private Animator CharacterCtl;
        private bool clickJump = false;
        #endregion
        #region 功能

        void jumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = true;
                print("跳躍!");
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
        #region 事件
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