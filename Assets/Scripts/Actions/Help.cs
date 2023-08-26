using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController controller, string noun)
    {
        controller.currentText.text = "Type a Verb followed by a noun(e.g. \"go north\")";
        controller.currentText.text += "\nAllowed verbs:\nGo, Examine, Give, Get, Use, Inventory, TalkTo, Say, Read, Help";
        controller.currentText.text += "\nPay attention to the words marked in <b>bold</b>, and interact with the <color=#FFA755FF><b>orange ones</b></color>.";
    }
}
