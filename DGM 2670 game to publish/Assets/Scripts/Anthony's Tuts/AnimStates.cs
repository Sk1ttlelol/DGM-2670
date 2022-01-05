using UnityEngine;
using UnityEngine.Events;

public class AnimStates : StateMachineBehaviour
{
  public UnityEvent enterStateEvent;

  override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    enterStateEvent.Invoke();
  }
}
