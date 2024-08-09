using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace BhjikmnBGYUik
{
    public class erghjm : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [FormerlySerializedAs("OnFixedUpdateHolding")] public UnityEvent cvbnm;

        private bool rtyuilk = false;

        public void OnPointerDown(PointerEventData eventData)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            rtyuilk = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            rtyuilk = false;
        }

        private void FixedUpdate()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            if (rtyuilk)
            {
                cvbnm.Invoke();
            }
        }
    }
}