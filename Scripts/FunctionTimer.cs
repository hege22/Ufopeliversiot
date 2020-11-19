using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FunctionTimer
{

    public static FunctionTimer Create(Action action, float timer){
       
        FunctionTimer functionTimer = new FunctionTimer(action, timer);

         GameObject gameObject = new GameObject("FunctionTimer", typeof(MonoBehaviourHook)); //luo uuden gameobjectin nimeltä FunctionTimer
        gameObject.GetComponent<MonoBehaviourHook>().onUpdate = functionTimer.Update; 

        return functionTimer;
    }

    public class MonoBehaviourHook : MonoBehaviour {
        public Action onUpdate;
        private void Update() {
            if (onUpdate != null) onUpdate();
        }
    }

    private Action action;
    private float timer;
    private bool isDestroyed;

    private FunctionTimer(Action action, float timer){
        this.action = action;
        this.timer = timer;
        isDestroyed = false;
    }

    public void Update()  { 
            if (!isDestroyed) { 
            timer -= Time.deltaTime; 
            if (timer < 0)
            {
                //Laukaisee actionin
                action();
                DestroySelf(); //ja tuhoaa itsensä, jotta se ei jäisi toistamaan itseään loputtomiin
              }
          }
        }
        private void DestroySelf() {
            isDestroyed = true;
        }
    }

    