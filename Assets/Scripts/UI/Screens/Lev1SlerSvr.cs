using HtjmwerSqw;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Uygbn.T78iop
{
    public class Lev1SlerSvr : Svr
    {
        [FormerlySerializedAs("levelButtons")] [SerializeField] private Button[] fwerbert;
        private LvrSdrWert _lvrSdrWert;

        private void Start()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            for (int i = 0; i < fwerbert.Length; ++i)
            {
                var t = i;
                fwerbert[i].onClick.AddListener(() => VfgyijkJBHGTFr(t));
            }
        }

        public void BVtgyuijknjHGHVTR(
            LvrSdrWert lvrSdrWert
            )
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            _lvrSdrWert = lvrSdrWert;
            
            NBtfijkJBHJTYTRD();
        }
        
        public void VfgyijkJBHGTFr(int fwerfv3412)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            DnundManager.GyikGTYuiol();
            _sndbhqwjl.ChanSerSvr<CseSvr, BGtyoijkNBHGVTY>(new BGtyoijkNBHGVTY { HGt6y7u8ijUHYGTFR = fwerfv3412 });
        }
        
        public override void JHYgtyui()
        {
            
            NBtfijkJBHJTYTRD();
            
            base.JHYgtyui();
        }
        
        private void NBtfijkJBHJTYTRD()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            for (int i = 0; i < fwerbert.Length; ++i)
            {
                fwerbert[i].interactable = i <= _lvrSdrWert.PswrLevs;
            }
        }
    }
}