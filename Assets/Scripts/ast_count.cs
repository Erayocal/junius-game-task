
using UnityEngine;
using UnityEngine.UI;

public class ast_count : MonoBehaviour
{
    static public ast_count astcalss;

    private void Start()
    {
        astcalss = this;
    }

    public Text count;
    private int countIndex;
   public void ast_cnt()
    {
        countIndex++;
        count.text = countIndex.ToString();
        Debug.Log("sayý arttý");
    }
}
