using UnityEngine;

public class ExplodingRole : BaseRole // Assuming BaseRole is your base class for roles
{
    public override void OnDeath()
    {
        // Call the base class OnDeath method if needed
        base.OnDeath();

        // Get all players in the same room
        Player[] playersInRoom = GetPlayersInRoom();

        // Loop through each player and apply damage or kill them
        foreach (Player player in playersInRoom)
        {
            if (player != this) // Ensure the player is not the one who died
            {
                player.Kill(); // Assuming Kill() is a method that kills the player
            }
        }

        // Optionally, you can add an explosion effect here
        Explode();
    }

    private Player[] GetPlayersInRoom()
    {
        // Implement logic to get all players in the same room
        // This could involve checking the player's current room or area
        return FindObjectsOfType<Player>(); // Example, adjust based on your game logic
    }

    private void Explode()
    {
        // Implement explosion logic here, such as playing an animation or sound
        Debug.Log("Exploded! All players in the room are dead.");
    }
}
