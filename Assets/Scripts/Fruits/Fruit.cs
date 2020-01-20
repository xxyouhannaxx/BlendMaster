using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BlendMaster
{
    public enum FruitSize
    {
        Full,
        Half,
        End,
    }
    public class Fruit : MonoBehaviour
    {
        [Header("General")]
        public int weight;
        public FruitSize size;
        [Header("Piece")]
        public GameObject nextPiece;
        public int piecesCount;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void generatePiece()
        {
            if (nextPiece != null)
            {
                for (int i = 0; i < piecesCount; i++)
                {
                    GameManager.Instance.fruitManager.addFruit(Instantiate(nextPiece).GetComponent<Fruit>());
                }
            }
            Destroy(gameObject);
        }
    }
}
