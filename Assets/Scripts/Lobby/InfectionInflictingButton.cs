using ObjectScripts;
using PlayerScripts;
using PlayerScripts.Controller;
using Unity.Netcode;
using UnityEngine;

namespace Lobby
{
    public class InfectionInflictingButton : NetworkBehaviour, IInteractable
    {
        public void Interact(Transform player)
        {
            player.GetComponent<PlayerHealth>().InflictInfection(10);
        }
    }
}