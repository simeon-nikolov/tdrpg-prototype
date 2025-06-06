using UnityEngine;

public class WalkingAdjuster : MonoBehaviour
{
    public Transform upperArmBone;
    public Transform lowerArmBone;
    public Transform handBone;
    private Animator animator;

    [Header("Offsets")]
    public Vector3 upperArmOffset = new Vector3(0, -55, 18);
    public Vector3 lowerArmOffset = new Vector3(0, 0, 45);
    public Vector3 handOffset = new Vector3(-90, 0, 0);

    void Start()
    {
        this.animator = gameObject.GetComponent<Animator>();
    }

    void LateUpdate()
    {
        if (this.upperArmBone == null || this.handBone == null || this.animator == null)
            return;

        if (animator.GetBool(AnimatorConstants.WALKING_PARAM))
        {
            this.upperArmBone.localEulerAngles = upperArmOffset;
            this.lowerArmBone.localEulerAngles = lowerArmOffset;
            this.handBone.localEulerAngles = handOffset;
        }
    }
}
