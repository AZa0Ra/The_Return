using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Read")]
public class Read : Action
{
    public override void RespondToInput(GameController controller, string noun)
    {
        if (ReadItem(controller, controller.player.currentLocation.items, noun))
            return;

        if (ReadItem(controller, controller.player.inventory, noun))
            return;

        controller.currentText.text = "There is no " + noun;
    }

    private bool ReadItem(GameController controller, List<Item> inventory, string noun)
    {
        foreach (Item item in inventory)
        {
            if (item.name.ToLower() == noun.ToLower())
            {
                if (controller.player.CanReadItem(controller, item))
                {
                    if (item.InteractWith(controller, "read"))
                        return true;
                }
                controller.currentText.text = "There is no " + noun + " that you can read";
                return true;
            }
        }
        return false;
    }
}
