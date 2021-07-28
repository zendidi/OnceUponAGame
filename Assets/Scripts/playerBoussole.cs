using UnityEngine;
using UnityEngine.UI;

public class playerBoussole : MonoBehaviour {
    public Image boussole;
    public float angle;
    public float ajustement;

    public Transform cible;

    private Vector3 direction;

    private void Update() {
        if(cible != null){
            boussole.gameObject.SetActive(true);
            direction = new Vector3(cible.position.x,0,cible.position.z) - new Vector3(transform.position.x, 0, transform.position.z) ;
            angle = Vector3.SignedAngle(direction, Vector3.left, Vector3.up);//Vector3.Angle(cible.position, direction);
            
            boussole.transform.rotation = Quaternion.Euler(0, 0, angle+ajustement); //.eulerAngles = new Vector3(0,0,angle);
        } else {
            boussole.gameObject.SetActive(false);
        }
    }

    public void changerDeCible(Transform newCible){
        cible = newCible;
    }
}