using UnityEngine;

namespace PlayerScripts.Controller
{
    public class PlayerRayCaster : MonoBehaviour
    {
        private Camera _playerCamera;

        private void Start()
        {
            _playerCamera = Camera.main;
        }
        public bool ViewPointRayCast(out RaycastHit hit, float distance)
        {
            Ray ray = _playerCamera.ViewportPointToRay(Vector3.one / 2f);
            return Physics.Raycast(ray, out hit, distance);
        }
    }
}
