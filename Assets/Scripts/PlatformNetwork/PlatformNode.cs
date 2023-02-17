using System;
using System.Collections.ObjectModel;
using UnityEngine;

namespace PlatformNodeNet
{
    [Serializable]
    public class PlatformNode : MonoBehaviour
    {
        [SerializeField] private Platform _platform;
        [SerializeField] private PlatformNode[] _connections;

        public Platform Platform => _platform; 
        public ReadOnlyCollection<PlatformNode> Connections => Array.AsReadOnly(_connections);

        private void OnDrawGizmosSelected()
        {
            if (_platform == null) return;

            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(_platform.transform.position, _platform.transform.localScale);

            Gizmos.color = Color.blue;
            foreach (PlatformNode p in _connections)
            {
                if (p == null) continue;

                Gizmos.DrawLine(_platform.transform.position, p.Platform.transform.position);
            }
        }
    }
}
