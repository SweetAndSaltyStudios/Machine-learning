using UnityEngine;

namespace Sweet_And_Salty_Studios
{
	public class CameraEngine : MonoBehaviour
	{
		#region VARIABLES

		[SerializeField] private Transform target = default;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY FUNCTIONS

        private void LateUpdate()
        {
            if(target == null) return;

            transform.LookAt(target);
        }

        #endregion UNITY FUNCTIONS

        #region CUSTOM FUNCTIONS

        #endregion CUSTOM FUNCTIONS	
    }
}