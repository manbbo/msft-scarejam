using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
    float aleatoryTiming = 0f;
    void Start()
    {
        aleatoryTiming = Random.Range(5.0f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {

        aleatoryTiming -= 1.0f * Time.deltaTime;
        if (aleatoryTiming <= 0.0f)
        {
            switch (Random.Range(0, 5))
            {
                case 0:
                    MusicManager.play("creak", 0.2f, 0.2f);
                        MusicManager.stop(3.5f);
                        randomize();
                    break;
                case 1:

                    MusicManager.play("drone", 0.2f, 0.2f);
                        MusicManager.stop(3.5f);
                        randomize();
                    break;
                case 2:
                    MusicManager.play("footstep", 0.2f, 0.2f);
                        MusicManager.stop(3.5f);
                        randomize();
                    break;
                case 3:
                    MusicManager.play("ghost", 0.2f, 0.2f);
                    
                        MusicManager.stop(3.5f);
                       randomize();
                    
                    break;
                case 4:
                    MusicManager.play("heart", 0.2f, 0.2f);
                    MusicManager.setVolume(1.0f, 3.5f);
                        MusicManager.stop(3.5f);
                      randomize();
                    
                    break;
                case 5:
                    MusicManager.play("laught", 0.2f, 0.2f);
                        MusicManager.stop(3.5f);
                        randomize();
                    break;
            }
        }
    }

    void randomize()
    {
        aleatoryTiming = Random.Range(10.0f, 20.0f);
    }
}