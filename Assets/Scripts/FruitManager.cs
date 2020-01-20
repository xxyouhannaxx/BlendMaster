using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BlendMaster
{
    public class FruitManager : MonoBehaviour
    {
        public List<Fruit> fruits;
        public float generatePositionX;
        public float generatePositionY;
        public List<Fruit> currentFruits;
        public bool isCutting;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void generateFruit()
        {
            currentFruits.Add(Instantiate(fruits[0], new Vector3(Random.Range(-generatePositionX, generatePositionX), generatePositionY, 0), Quaternion.identity));
        }
        public void destroyItem()
        {
            if (currentFruits.Count == 0) return;
            int index = Random.Range(0, currentFruits.Count);
            currentFruits[index].generatePiece();
            currentFruits.RemoveAt(index);
        }
        public void addFruit(Fruit fruit)
        {
            currentFruits.Add(fruit);
        }
        public void startDestuction()
        {
            StartCoroutine(timedDestruction());
            isCutting = true;
        }
        IEnumerator timedDestruction()
        {
            yield return new WaitForSeconds(0.5f);
            if (isCutting)
            {
                destroyItem();
                StartCoroutine(timedDestruction());
            }
        }
    }
}
