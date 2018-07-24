using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Ball
{


    public class Ball : MonoBehaviour
    {
      
        
        private Rigidbody m_Rigidbody;
        public float force = 10f;
        private int sceneIndex;
        public int hits = 0;
        static int score = 0;
       

        public Text hitText;
        public Text scoreText;
        public Text bogeyText;

        public GameObject holeInOne;
        public GameObject birdie;
        public GameObject par;
        public GameObject bogey;
        public GameObject dbogey;
        public GameObject tBogey;
        public GameObject superBogey;
        
        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
         
        }


        private void OnTriggerEnter(Collider collider)
        {
            if (collider.name == "hole")
            {
                Debug.Log("In the hole");
                checkScore();
                updateScore();
                StartCoroutine(loadNext());
             
               
            }
               

        }
        void checkScore()
        {
            if(hits == 1)            
                holeInOne.SetActive(true);      
            if(hits == 2)            
                birdie.SetActive(true);            
            if (hits == 3)
                par.SetActive(true);
            if (hits == 4)
                bogey.SetActive(true);
            if (hits == 5)
                dbogey.SetActive(true);
            if (hits == 6)
                tBogey.SetActive(true);
            if(hits >= 7)
            {
                updateBogey();
                superBogey.SetActive(true);
            }
                
        }
        
        void updateScore()
        {
            score = score + hits;
            scoreText.text = "Score: " + score;
        }

        void updateBogey()
        {
            int overScore = hits - 3;
            bogeyText.text = overScore + " - Bogey";
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.name == "Car")
            {
                hits = hits + 1;
                hitText.text = "Hits: " + hits;
               
                Debug.Log("Collided by Car");
                
                Vector3 forceVec = GetComponent<Rigidbody>().velocity.normalized * force;

                GetComponent<Rigidbody>().AddForce(forceVec, ForceMode.Impulse);
                    
                
            }
        }

        
        IEnumerator loadNext()
        {

            yield return new WaitForSeconds(1);
            int sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(sceneIndex);
            
        } 
    }
}
