using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Uygbn.T78iop
{
    public class SrtbeOertSvr : Svr
    {
        [FormerlySerializedAs("musicIcon")] [SerializeField] private Image fhywehkjkf;
        [FormerlySerializedAs("soundIcon")] [SerializeField] private Image zuy78uijkqweri;
        [FormerlySerializedAs("soundToggle")] [SerializeField] private Toggle VTyuyijk2421;
        [FormerlySerializedAs("musicToggle")] [SerializeField] private Toggle NHyhjkw1243;
        [FormerlySerializedAs("musicSlider")] [SerializeField] private Slider NByghjkl123;
        [FormerlySerializedAs("soundSlider")] [SerializeField] private Slider JUIygsajdko2ui34;
        [FormerlySerializedAs("musicSprite")] [SerializeField] private Sprite OIgbdnoqiwi43;
        [FormerlySerializedAs("soundSprite")] [SerializeField] private Sprite KOjdkljwui432;
        [FormerlySerializedAs("musicDisabledSprite")] [SerializeField] private Sprite JHUIsbioidnqwieugr2;
        [FormerlySerializedAs("soundDisabledSprite")] [SerializeField] private Sprite OPIhiuqwpojqio43;
        
        public void POnoewqld()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            IOBpewboui1j();
        }

        /*
        public void ToggleMusic()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            _soundManager.OnButtonClick();
            _soundManager.IsMusicTurnedOn = !_soundManager.IsMusicTurnedOn;
            UpdateIcons();
        }

        public void ToggleSound()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            _soundManager.OnButtonClick();
            _soundManager.IsSoundTurnedOn = !_soundManager.IsSoundTurnedOn;
            UpdateIcons();
        }*/

        public void OIUBnpdqwio12()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            DnundManager.DrtWErt = (int)(JUIygsajdko2ui34.value * 100) - 100;
        }

        public void UGbpqwhguie142()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            DnundManager.MdrWert = (int)(NByghjkl123.value * 100) - 100;
        }

        public void OIUvwbepqw124()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            DnundManager.bgyuikJYtgb = !DnundManager.bgyuikJYtgb;
            DnundManager.GyikGTYuiol();
            IOBpewboui1j();
        }

        public void OIbwdpqwnbvUYVI()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            DnundManager.ghkYTgbnm = !DnundManager.ghkYTgbnm;
            DnundManager.GyikGTYuiol();
            IOBpewboui1j();
        }

        private void IOBpewboui1j()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            zuy78uijkqweri.sprite = DnundManager.ghkYTgbnm 
                ? OPIhiuqwpojqio43 
                : KOjdkljwui432;
            fhywehkjkf.sprite = DnundManager.bgyuikJYtgb
                ? JHUIsbioidnqwieugr2
                : OIgbdnoqiwi43;
            
            // soundToggle.isOn = _soundManager.IsSoundTurnedOn;
            // musicToggle.isOn = _soundManager.IsMusicTurnedOn;

            JUIygsajdko2ui34.value = (float)(DnundManager.DrtWErt + 100) / 100;
            NByghjkl123.value = (float)(DnundManager.MdrWert + 100) / 100;
        }
    }
}