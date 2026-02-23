using UnityEngine;

public class Orbit : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private int _orbitHeight;
    [SerializeField] private Transform _orbitCenter;

    [Header("Speed")]
    [SerializeField] private float _orbitSpeed;
    [SerializeField] private OrbitSO _orbitParams; //min and max speed

    [SerializeField] private Rigidbody _rigidbody;

    //private Star _star;
    private bool _magneting = false;
    private bool _onOrbit;

    #region PUBLIC
    public void StartMangeting()
    {
        _magneting = true;
        _onOrbit = false;
    }

    public void StopMangeting()
    {
        TryStayOnOrbit();
    }
    #endregion
    #region PRIVET

    private void OnCollisionEnter(Collision collision)
    {
        _onOrbit = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        TryStayOnOrbit();
    }

    private void SetStartParameters()
    {
        //_star = Star.instance;
        //_orbitCenter = _star.transform;
        _orbitHeight = Mathf.CeilToInt(Vector3.Magnitude(_orbitCenter.position - transform.position));
    }

    //private void FixedUpdate()
    //{
    //    if (!_magneting && _onOrbit && _orbitCenter != null)
    //    {
    //        OrbitMove();
    //    }
    //    //else if (Vector3.Distance(transform.position, _orbitCenter.position) > _star.MaxPlanetRange)
    //    //{

    //        //}
    //    else
    //        MoveToStar();
    //}

    private void MoveToStar()
    {
        Vector3 vectorToOrbitCenter = _orbitCenter.position - transform.position;
        //_rigidbody.AddForce(vectorToOrbitCenter.normalized * _star.GravityForce, ForceMode.Force);
    }

    private void OrbitMove()
    {
        Vector3 moveVector = GetMoveVector();
        _rigidbody.velocity = _orbitSpeed * moveVector;
    }


    private void TryStayOnOrbit()
    {
        float distance = Vector3.Distance(transform.position, _orbitCenter.position);

        //if (distance > _star.MaxPlanetRange) return;
        float probablySpeed = _rigidbody.velocity.magnitude;
        //if (probablySpeed < _star.MinSpeedToMaintainOrbit || probablySpeed > _star.MaxSpeedToMaintainOrbit) return;

        Vector3 moveVector = GetMoveVector();

        float angleRightVector = Vector3.Angle(_rigidbody.velocity, -moveVector);
        float angleLeftVector = Vector3.Angle(_rigidbody.velocity, moveVector);
        if (Mathf.Min(angleRightVector, angleLeftVector) > 30) return;

        bool right = false;
        if (angleRightVector < angleLeftVector)
        {
            _orbitSpeed = -probablySpeed;
            right = true;
        }
        else _orbitSpeed = probablySpeed;

        _orbitHeight = Mathf.CeilToInt(distance);
        _onOrbit = true;
        _magneting = false;

    }

    private Vector3 GetMoveVector()
    {
        Vector3 vectorToOrbitCenter = _orbitCenter.position - transform.position;
        return Vector3.Cross(vectorToOrbitCenter.normalized, Vector3.up);
    }
    #endregion


#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, GetMoveVector() * 15);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, GetMoveVector() * -15);
    }
#endif
}