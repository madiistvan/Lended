using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourlerper : MonoBehaviour
{
    public float every;  //The public variable "every" refers to "Lerp the color every X"
    float colorstep;
    Color[] colors = new Color[4]; //Insert how many colors you want to lerp between here, hard coded to 4
    int i;
    Color lerpedColor = Color.red;  //This should optimally be the color you are going to begin with

    void Start()
    {

        //In here, set the array colors you are going to use, optimally, repeat the first color in the end to keep transitions smooth

        colors[0] = new Color(0f, 0.5803922f, 0.09119608f,0.5f);
        colors[1] = new Color(0f, 0.5724528f, 0.0940667f, 0.5f);
        colors[2] = new Color(0f, 0.5635849f, 0.09569811f, 0.5f);
        colors[3] = new Color(0f, 0.5703922f, 0.0923221f, 0.5f);

    }


    // Update is called once per frame
    void Update()
    {

        if (colorstep < every)
        { //As long as the step is less than "every"
            lerpedColor = Color.Lerp(colors[i], colors[i + 1], colorstep);
            this.GetComponent<SpriteRenderer>().color = lerpedColor;
            colorstep += 0.009f;  //The lower this is, the smoother the transition, set it yourself
        }
        else
        { //Once the step equals the time we want to wait for the color, increment to lerp to the next color

            colorstep = 0;

            if (i < (colors.Length - 2))
            { //Keep incrementing until i + 1 equals the Lengh
                i++;
            }
            else
            { //and then reset to zero
                i = 0;
            }
        }
    }
}
