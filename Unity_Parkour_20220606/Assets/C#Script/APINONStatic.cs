using UnityEngine;

namespace Ben
{
    /// <summary>
    /// 實體物件:存在於場景上的物件
    /// </summary>
    public class APINONStatic : MonoBehaviour
    {
        [SerializeField]
        GameObject frog;
        [SerializeField]
        private Transform endPoint;


        void Start()
        {
            print("忍者蛙的啟動狀態: "+frog.activeInHierarchy);
            frog.layer = 4;
            frog.tag = "player";
            print("忍者蛙的tag: " + frog.tag);
            print("忍者蛙的layer: " + frog.layer);
            frog.SetActive(false);

            print("終點的座標: "+endPoint.position);
            endPoint.position = new Vector3(0, 0, 0);
        }
        private void Update()
        {
            endPoint.Translate(1.5f,0,0);
            endPoint.Rotate(0, 0, 3.5f);
        }
    }

}