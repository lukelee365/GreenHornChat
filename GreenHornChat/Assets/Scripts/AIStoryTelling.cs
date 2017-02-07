

using UnityEngine;
using UnityEngine.UI;

public class AIStoryTelling : MonoBehaviour
{


    public Text textPanel;
    public Image imageUI;
    public Sprite sprite;
    private int steps;
    private bool newStep;
    public string startText;
    public string secondText;
    public string lastText;
    private double timer;
    private bool imageStep;
	public double setupTime;
   
	// Use this for initialization
	void Start ()
	{
	    steps = 1;
	    timer = setupTime;
        
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        StoryStep(steps);
        if (newStep)
	    {
	        timer -= 0.8*Time.deltaTime;
           
	    }
	    if (newStep && timer <= 0)
	    {
	        newStep = false;
            StoryStep(steps);
            steps++;
            timer = setupTime;
	        
           

	    }
	    if (ImageUpload.imageSubmitted)
	    {
	        newStep = true;
	        ImageUpload.imageSubmitted = false;
	    }
	}

    public void Post(string text)
    {
        if (timer <= 0)
        {
            textPanel.text += "\n" + "<color=Red>" + text + "</color>";
            if (imageStep)
            {
                imageUI.sprite = sprite;
                imageStep = false;
            }
        }
       
       
    }

    private void StoryStep(int number)
    {
        switch (number)
        {
            case 1:
               
                Post(startText);
                newStep = true;
                break;
            case 2:
               
                Post(secondText);
                imageStep = true;
                
                break;
            case 3: 
               
                Post(lastText);
                break;
        }
    }
}
