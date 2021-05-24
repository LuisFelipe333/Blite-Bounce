using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRectangleMultiplayer : MonoBehaviour
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
        /*if(Input.GetKeyUp("space")&&!black)
        {
            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",true);

            foreach(ChangeSquare checkBlack in squaresBlack)
            checkBlack.black=true;
            black=true;
        }
        else
        {
            if(Input.GetKeyUp("space")&&black)
            {

            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",false);
            
            foreach(ChangeSquare checkBlack in squaresBlack)
            checkBlack.black=false;

            black=false;
            }
        }
        */

        //Component[] squaresAnimation=gameObject.GetComponentsInChildren<Animator>();//obtiene el componente animator de los cuadrados
        //Component[] squaresBlack=gameObject.GetComponentsInChildren<ChangeSquare>();//obtiene el script ChangeSquare de los cuadrados
        /*
        if(!isPressed&&(joystick.Vertical!=0||joystick.Horizontal!=0)&&!black)
        {
            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",true);

            foreach(ChangeSquare checkBlack in squaresBlack)
            checkBlack.black=true;
            black=true;
            isPressed=true;
        }
        else
        {
            if(!isPressed&&(joystick.Vertical!=0||joystick.Horizontal!=0)&&black)
            {

            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",false);
            
            foreach(ChangeSquare checkBlack in squaresBlack)
            checkBlack.black=false;

            black=false;
            isPressed=true;
            }
        }

        if(joystick.Vertical==0&&joystick.Horizontal==0)
        isPressed=false;
        */

    }

    public void changeColor()
    {
        Debug.Log("Aqui si llego");
        Component[] squaresAnimation=gameObject.GetComponentsInChildren<Animator>();
        Component[] squaresBlack=gameObject.GetComponentsInChildren<ChangeSquareMultiplayer>();
        if(!black)
        {
            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",true);

            foreach(ChangeSquareMultiplayer checkBlack in squaresBlack)
            checkBlack.black=true;
            black=true;
            
        }
        else
        {
            if(black)
            {

            foreach(Animator animator in squaresAnimation)
            animator.SetBool("black",false);
            
            foreach(ChangeSquareMultiplayer checkBlack in squaresBlack)
            checkBlack.black=false;

            black=false;
            
            }
        }
    }


}