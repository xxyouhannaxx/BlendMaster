using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BlendMaster
{
    public class Blender : MonoBehaviour
    {
        public SpriteProgressBar blenderFiller;
        public Renderer liquidObject;
        public Animator animator;
        public bool isFilling;
        public float fillAmount;
        public float fillIncrimentation;
        // Start is called before the first frame update
        void Start()
        {
            startFill2();
        }

        // Update is called once per frame
        void Update()
        {
            if (isFilling) fill2();
        }

        public void startFilling()
        {
            isFilling = true;
            animator.SetBool("Shake", true);
        }
        public void stopFilling()
        {
            isFilling = false;
            animator.SetBool("Shake", false);
        }
        public void startFill1()
        {
            fillAmount = 0;
            blenderFiller.setProgress(0);
            animator.SetBool("Shake", true);

        }
        private void fill()
        {
            fillAmount += fillIncrimentation;
            if (fillAmount > 1) fillAmount = 1;
            blenderFiller.setProgress(fillAmount);
        }
        public void startFill2()
        {
            fillAmount = 2.2f;
            liquidObject.material.SetFloat("_FillAmount", fillAmount);
            GameManager.Instance.fruitManager.startDestuction();
        }
        public void fill2()
        {
            fillAmount -= fillIncrimentation;
            if (fillAmount < 0) fillAmount = 0;
            liquidObject.material.SetFloat("_FillAmount", fillAmount);
        }
    }
}