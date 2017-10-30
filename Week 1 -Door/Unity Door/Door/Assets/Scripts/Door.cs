using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{

    private int m_LI;

    public void PlayDoorAnim()
    {

        
            if (m_LI == 0)
            {
                GetComponent<Animation>().Play("Pivot");
                m_LI = 1;




            }

            else
            {
                GetComponent<Animation>().Play("Pivot_Close");
                m_LI = 0;

            }

        }

    }


