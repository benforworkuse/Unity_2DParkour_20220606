using UnityEngine;
/// <summary>
/// 跳躍系統
/// </summary>
namespace Ben
{

    public class SystemJump : MonoBehaviour
    {
        #region 資料
        

        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;

        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;

        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);

        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;

        [SerializeField, Header("跳躍動畫參數")]
        private string nameJump = "跳躍開關";

        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;

        [SerializeField, Header("跳躍高度"), Tooltip("跳躍高度"), Range(0, 3000)]
        private float JumpHeight = 350;
        private Rigidbody2D rig;
        private Animator CharacterCtl;
        private bool clickJump = false;
        private bool isGround;
        private AudioSource aud;

        #endregion
        #region 功能

        void jumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        void jump()
        {
            if (clickJump&&isGround)
            {
                rig.AddForce(new Vector2(0, JumpHeight));
                clickJump = false;
                aud.PlayOneShot(soundJump,1f);
            }
        }
        void detectGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position+v3CheckGroundOffset,v3CheckGroundSize,0,layerCheckGround);
            //print(hit.name+ " be hitted. ");
            isGround = hit;
            print(isGround);
        }

        private void UpdateAnimator()
        {
            CharacterCtl.SetBool(nameJump, !isGround);
        }
        #endregion
        #region 事件
        private void OnDrawGizmos()
        {
            Gizmos.color = colorCheckGround;
            Gizmos.DrawCube(transform.position+v3CheckGroundOffset,v3CheckGroundSize);
        }
        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            CharacterCtl = GetComponent<Animator>();
            aud = GetComponent<AudioSource>();
        }
        private void Update()
        {
            jumpKey();
            detectGround();
            UpdateAnimator();
        }
        private void FixedUpdate()
        {
            jump();

        }
        #endregion
    }
}