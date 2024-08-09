using System;
using System.Collections;
using System.Linq;
using HtjmwerSqw;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace NBuikmTYuio
{
    public class GField : MonoBehaviour
    {
        [FormerlySerializedAs("spheres")] [SerializeField] private Collstin[] collstins;
        [FormerlySerializedAs("colors")] [SerializeField] private Sprite[] clrs;
        [SerializeField] private int seed;

        private Collstin _openedCollstin;
        private int _mtcCond = 0;
        private int _trsCntColl = 0;
        private int _scrtg;
        private int _dfeWer = 0;
        private int _mvSwer = 0;
        private DnundManager _dnundManager;

        public event Action<int> OnScCnn;
        public event Action<int> JHygtfyguhj;
        public event Action bytrewsfg;
        public event Action<int> okuyTRTFYU;

        public int Scrtg => _scrtg;
        
        private void Start()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            foreach (var collstin in collstins)
            {
                collstin.hrdcd += () => OkjezUJQQw(collstin);
            }

            JHygtfyguhj.Invoke(0);
            okuyTRTFYU.Invoke(0);
        }

        public void BGT98okmjnhgyt(DnundManager dnundManager, int qwe12wdr, int poiuygfvc)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            _dnundManager = dnundManager;
            seed = poiuygfvc;
            ShuffleClrs(seed);
        }
        
        public void AWccewr()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            StartCoroutine(TckWer());
        }

        private void ShuffleClrs(int seed)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            if (clrs.Length != collstins.Length / 2)
                throw new ArgumentException("Not valid count of clrs");
            
            Random.InitState(seed);
            int k = 0;
            
            foreach (int i in Enumerable.Range(0, collstins.Length).OrderBy(_ => Random.Range(0, collstins.Length)))
            {
                collstins[i].ChnCLllr(clrs[k % clrs.Length]);
                k += 1;
            }
        }

        private void OkjezUJQQw(Collstin collstin)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            _dnundManager.Hgfr6789iKJHYT5();
            if (_openedCollstin is null)
            {
                _openedCollstin = collstin;
                return;
            }

            _trsCntColl += 1;
            _mvSwer += 1;
            
            JHygtfyguhj.Invoke(_mvSwer);

            if (collstin.CollstingSprite == _openedCollstin.CollstingSprite)
            {
                _scrtg += Mathf.RoundToInt(1f / Math.Min(_trsCntColl, 1) * 1);
                _trsCntColl = 0;
                // _dnundManager.OnCoinCollect();
                OnScCnn?.Invoke(_scrtg);
                
                _mtcCond += 2;
                _openedCollstin = null;

                if (_mtcCond == collstins.Length)
                {
                    _dnundManager.OnDer();
                    bytrewsfg?.Invoke();
                }

                return;
            }

            _openedCollstin.Close();
            _openedCollstin = null;
            collstin.Close();
        }
        
        private IEnumerator TckWer()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            while (true)
            {
                _dfeWer += 1;
                
                okuyTRTFYU.Invoke(_dfeWer);

                yield return new WaitForSeconds(1);
            }
        }
    }
}