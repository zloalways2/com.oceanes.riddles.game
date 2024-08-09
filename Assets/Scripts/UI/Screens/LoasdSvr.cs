using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Uygbn.T78iop
{
    public class LoasdSvr : Svr
    {
        [FormerlySerializedAs("progress")] [SerializeField] private Image JHuftgvjhkjio8;
        [FormerlySerializedAs("loadingDuration")] [SerializeField] private float kijtvghjkoi123d = 12f;
        
        public void JOgyghjnkklIYT()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            StartCoroutine(Gtf87uionkHGYTF65());
        }

        private IEnumerator Gtf87uionkHGYTF65()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            var cfywteghbdkk = 0f;
            JHuftgvjhkjio8.fillAmount = cfywteghbdkk;
            
            while (cfywteghbdkk < kijtvghjkoi123d)
            {
                cfywteghbdkk += Time.deltaTime;
                
                JHuftgvjhkjio8.fillAmount = cfywteghbdkk / kijtvghjkoi123d;
                
                yield return null;
            }
            
            DnundManager.StveWdrGdwer();
            _sndbhqwjl.ChanSerSvr<HelSwreSvr>();
        }
    }
}