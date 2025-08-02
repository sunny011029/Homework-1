using UnityEngine;

public class PreGameVCController : MonoBehaviour
{
    public Transform[] VCPoitns;
    public bool isArrived;
    private Transform curPoint;

    private int curIndex = 1;
    // Start is called before the first frame update
    void Start()
    {
        curIndex = 1;
        curPoint = VCPoitns[curIndex];
          
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(curPoint.position - transform.position);

        if (Vector3.Distance(curPoint.position, transform.position) < 0.1f£©
        {
            if (curIndex == 0)
                curIndex == 1;
            else
                curIndex == 0;
            curPoint = VCPoitns 
        }

    }
}
