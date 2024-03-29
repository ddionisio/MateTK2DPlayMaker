using UnityEngine;
using HutongGames.PlayMaker;

namespace M8.PlayMaker {
    [ActionCategory("Mate tk2D")]
    [Tooltip("Pause the sprite animator.")]
    public class SpriteAnimator3DPause : FSMActionComponentBase<SpriteAnimator3D> {

        [Tooltip("Pause flag")]
        public FsmBool pause;

        [ActionSection("")]

        [Tooltip("Repeat every frame.")]
        public bool everyframe;

        public override void Reset() {
            base.Reset();

            pause = true;
            everyframe = false;
        }

        // Code that runs on entering the state.
        public override void OnEnter() {
            base.OnEnter();

            DoPause();

            if(!everyframe)
                Finish();
        }

        public override void OnUpdate() {
            DoPause();
        }

        void DoPause() {
            mComp.paused = pause.Value;
        }
    }
}
