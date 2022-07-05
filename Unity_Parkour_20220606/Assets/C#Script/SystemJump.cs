using UnityEngine;
/// <summary>
/// ���D�t��
/// </summary>
namespace Ben
{

    public class SystemJump : MonoBehaviour
    {
        #region ���
        

        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;

        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;

        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);

        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;

        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string nameJump = "���D�}��";

        [SerializeField, Header("���D����")]
        private AudioClip soundJump;

        [SerializeField, Header("���D����"), Tooltip("���D����"), Range(0, 3000)]
        private float JumpHeight = 350;
        private Rigidbody2D rig;
        private Animator CharacterCtl;
        private bool clickJump = false;
        private bool isGround;
        private AudioSource aud;

        #endregion
        #region �\��

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
        #region �ƥ�
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