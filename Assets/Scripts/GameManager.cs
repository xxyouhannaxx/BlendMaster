using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlendMaster
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public Blender blender;
        public FruitManager fruitManager;
        private void Awake()
        {
            Instance = this;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                fruitManager.generateFruit();
            }
        }
        public void fillBlender()
        {
            blender.startFilling();
        }
        public void stopFilling()
        {
            blender.stopFilling();
        }
    }
}
