using UnityEngine;
using TMPro;
using System;
public class DropdownMenu : MonoBehaviour
{
    public Boolean Beginner;
    public TextMeshProUGUI PullOutput;
    public TextMeshProUGUI LegOutput;
    public TextMeshProUGUI DipOutput;
    public TextMeshProUGUI HingeOutput;
    public TextMeshProUGUI RowOutput;
    public TextMeshProUGUI PushUpOutput;
    public TMP_Dropdown IsBeginnerDropdown;
    public TMP_Dropdown MaxLegDropdown;
    public TMP_Dropdown MaxDipDropdown;
    public TMP_Dropdown MaxHingeDropdown;
    public TMP_Dropdown MaxRowDropdown;
    public TMP_Dropdown MaxPushUpDropdown;
    public void HandleImputData(int val)
    {
        if (Beginner == false)
        {
            if (val == 0)
            {
                PullOutput.text = "Select Your Capacity";
            }

             if (val == 1)
            {
                PullOutput.text = "Scapular Pulls 3x5-8";
            }

            if (val == 2)
            {
                PullOutput.text = "Arch Hangs 3x5-8";
            }

            if (val == 3)
            {
                PullOutput.text = "Negative pullup 10sec";
            }

            if (val == 4)
            {
                PullOutput.text = "Pullups 3x5-8";
            }

            if (val == 5)
            {
                PullOutput.text = "Weighted Pullups 3x5-8";
            }
        }
       
        
    }

    public void IsBeginner()
    {
        if (IsBeginnerDropdown.value == 1)
        {
            Beginner = true;
            PullOutput.text = LegOutput.text = DipOutput.text = HingeOutput.text =RowOutput.text = PushUpOutput.text = "Do the primer routine!!!";
        }

        if (IsBeginnerDropdown.value == 0)
        {
            Beginner = false;
            PullOutput.text = "Calisthenics";
        }
    }



    public void LegSelect()
    {
        if (MaxLegDropdown.value == 0)
        {
            
            LegOutput.text = "Select Your Capacity";
        }

        if (MaxLegDropdown.value == 1)
        {
            
            LegOutput.text = "Assisted squat 3x5-8";
        }

          if (MaxLegDropdown.value == 2)
        {
            
            LegOutput.text = "Squat 3x5-8";
        }

          if (MaxLegDropdown.value == 3)
        {
            
            LegOutput.text = "Bulgarian Split squat 3x5-8";
        }

          if (MaxLegDropdown.value == 4)
        {
            
            LegOutput.text = "Shrimp Squats 3x5-8";
        }
    }

    public void DipSelect()
    {
        if (MaxDipDropdown.value == 0)
        {
            
            DipOutput.text = "Select Your Capacity";
        }

        if (MaxDipDropdown.value == 1)
        {
            
            DipOutput.text = "Parallel Bar Support Hold 1min";
        }

          if (MaxDipDropdown.value == 2)
        {
            
            DipOutput.text = "Negative Dips 10sec";
        }

          if (MaxDipDropdown.value == 3)
        {
            
            DipOutput.text = "Parallel Bar Dips 3x5-8";
        }

          if (MaxDipDropdown.value == 4)
        {
            
            DipOutput.text = "Weighted Dips 3x5-8";
        }

 
    }

    public void HingeSelect()
    {
        if (MaxHingeDropdown.value == 0)
        {
            
            HingeOutput.text = "Select Your Capacity";
        }

        if (MaxHingeDropdown.value == 1)
        {
            
            HingeOutput.text = "Romanian Deadlift 3x5-8";
        }

          if (MaxHingeDropdown.value == 2)
        {
            
            HingeOutput.text = "Single Legged Deadlift 3x5-8";
        }

          if (MaxHingeDropdown.value == 3)
        {
            
            HingeOutput.text = "Banded Nordic Curl Negatives";
        }

          if (MaxHingeDropdown.value == 4)
        {
            
            HingeOutput.text = "Banded Nordic Curl 3x5-8";
        }

        if (MaxHingeDropdown.value == 5)
        {
            
            HingeOutput.text = "Nordic Curl 3x5-8";
        }

 
    }

    public void RowSelect()
    {
        if (MaxRowDropdown.value == 0)
        {
            
            RowOutput.text = "Select Your Capacity";
        }

        if (MaxRowDropdown.value == 1)
        {
            
            RowOutput.text = "Vertical Rows 3x5-8";
        }

          if (MaxRowDropdown.value == 2)
        {
            
            RowOutput.text = "Incline Rows 3x5-8";
        }

          if (MaxRowDropdown.value == 3)
        {
            
            RowOutput.text = "Horizontal Rows 3x5-8";
        }

          if (MaxRowDropdown.value == 4)
        {
            
            RowOutput.text = "Wide Rows 3x5-8";
        }

        if (MaxRowDropdown.value == 5)
        {
            
            RowOutput.text = "Weighted Inverted Rows 3x5-8";
        }

 
    }

    public void PushUpSelect()
    {
        if (MaxPushUpDropdown.value == 0)
        {
            
            PushUpOutput.text = "Select Your Capacity";
        }

        if (MaxPushUpDropdown.value == 1)
        {
            
            PushUpOutput.text = "Vertical Pushup 3x5-8";
        }

          if (MaxPushUpDropdown.value == 2)
        {
            
            PushUpOutput.text = "Incline Pushup 3x5-8";
        }

          if (MaxPushUpDropdown.value == 3)
        {
            
            PushUpOutput.text = "Full Pushup 3x5-8";
        }

          if (MaxPushUpDropdown.value == 4)
        {
            
            PushUpOutput.text = "Diamond Pushup 3x5-8";
        }

        if (MaxPushUpDropdown.value == 5)
        {
            
            PushUpOutput.text = "Pseudo Planche Pushups 3x5-8";
        }

 
    }

}
