using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   public Text scoreText;
//    public GameObject playyagain;
//    public GameObject exitbutton;
   public Button mainmenubutton;
   public Text Finalscore;
   private Blade blade;
   private Spawner spawner;
   //public Image fadeImage;
   private int score;

   private void Awake()
   {
    blade = FindObjectOfType<Blade>();
    spawner = FindObjectOfType<Spawner>();
   }

   private void start()
   {
    // playyagain.SetActive(false);
    // exitbutton.SetActive(false);
    mainmenubutton.gameObject.SetActive(false);
    NewGame();
   }
   private void NewGame()
   {
    
    Time.timeScale = 1f;
    blade.enabled = true;
    spawner.enabled = true;
    score = 0;
    scoreText.text = score.ToString();
    ClearScene();
   } 

   private void ClearScene()
   {
    
    Fruit[] fruits = FindObjectsOfType<Fruit>();
    foreach(Fruit fruit in fruits)
    {
        Destroy(fruit.gameObject);
    }

    Bomb[] bombs = FindObjectsOfType<Bomb>();
    foreach(Bomb bomb in bombs)
    {
        Destroy(bomb.gameObject);
    }
   }

   public void IncreaseScore(int amount)
   {
     score += amount;
     scoreText.text = score.ToString();
   }

   public void Explode()
   {
    //UnityEngine.Debug.Log(" Game Over 0 ");
    blade.enabled = false;
    //UnityEngine.Debug.Log(" Game Over 1 ");
    spawner.enabled = false;
    //UnityEngine.Debug.Log(" Game Over 2 ");
    //pausegame();
    
    Finalscore.text = "Your Score : " + score.ToString();
    //Invoke(Finalscore.text, 5f);
    //StartCoroutine(waiter());
    choice();
    //StartCoroutine(ExplodeSequence());
    UnityEngine.Debug.Log(" Game Over 3 ");
    //SceneManager.LoadScene(0);
    
   }
   public void choice()
   {
     mainmenubutton.gameObject.SetActive(true);
   }
   public void Playagain()
    {
       SceneManager.LoadScene(0);
    }

}
//    private IEnumerator pausegame()
//    {
//     yield return new WaitForSecondsRealtime(5f);
//    }
//    private IEnumerator ExplodeSequence()
//    {
    
//     UnityEngine.Debug.Log(" Game Over 300 ");
//     float elapsed = 0f;
//     float duration = 1f;
//     //fade to white
//     UnityEngine.Debug.Log(" Game Over 301 ");
//     while(elapsed < duration)
//     {
//         UnityEngine.Debug.Log(" Game Over 3011 ");
//         float t = Mathf.Clamp01(elapsed/duration);
//         UnityEngine.Debug.Log(" Game Over 3012 ");
//         fadeImage.color = Color.Lerp(Color.clear,Color.white, t);
//         UnityEngine.Debug.Log(" Game Over 3013 ");
//         Time.timeScale = 1f - t;
//         UnityEngine.Debug.Log(" Game Over 3014 ");
//         elapsed += Time.unscaledDeltaTime;
//         UnityEngine.Debug.Log(" Game Over 3015 ");
//         yield return null;
//         UnityEngine.Debug.Log(" Game Over 3016 ");
//     }
//     UnityEngine.Debug.Log(" Game Over 302 ");
//     yield return new WaitForSecondsRealtime(1f);
//     UnityEngine.Debug.Log(" Game Over 303 ");
//     elapsed = 0f;
//     //fade back in
//     UnityEngine.Debug.Log(" Game Over 304 ");
//     while(elapsed < duration)  
//     {
//         float t = Mathf.Clamp01(elapsed/duration);
//         fadeImage.color = Color.Lerp(Color.white,Color.clear, t);

//         elapsed += Time.unscaledDeltaTime;

//         yield return null;
//     }
//     UnityEngine.Debug.Log(" Game Over 305 ");
//     yield return new WaitForSecondsRealtime(1f);
//   }
