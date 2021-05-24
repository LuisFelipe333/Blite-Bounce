using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvRectangle : MonoBehaviour
{
    public bool black;  
    //  bool isPressed;
    //public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        black=false;
        
        //isPressed=false;
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void changeColor()
    {
        Component[] squaresAnimation=gameObject.GetComponentsInChildren<Animator>();
        Component[] squaresBlack=gameObject.GetComponentsInChildren<SurvChangeSquares>();
        if(!black)
        {
            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",true);

            foreach(SurvChangeSquares checkBlack in squaresBlack)
            checkBlack.black=true;
            black=true;
            
        }
        else
        {
            if(black)
            {

            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",false);
            
            foreach(SurvChangeSquares checkBlack in squaresBlack)
            checkBlack.black=false;

            black=false;
            
            }
        }
    }

    public void UpdateColors()
    {
        Component[] squaresAnimation=gameObject.GetComponentsInChildren<Animator>();
        Component[] squaresBlack=gameObject.GetComponentsInChildren<SurvChangeSquares>();
        if(black)
        {
            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",true);

            foreach(SurvChangeSquares checkBlack in squaresBlack)
            checkBlack.black=true;
            
        }
        else
        {
            if(!black)
            {

            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",false);
            
            foreach(SurvChangeSquares checkBlack in squaresBlack)
            checkBlack.black=false;
            
            }
        }
        
    }


}
