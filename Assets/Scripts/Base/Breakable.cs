using UnityEngine;

/// <summary>
/// 会被破坏的物体
/// </summary>
public class Breakable : MonoBehaviour {
	/// <summary>
	/// 还剩下被攻击的次数
	/// </summary>
	[SerializeField] protected int health;
	[SerializeField] protected bool isDead;

	protected void CheckIsDead () {
		if (health <= 0 && !isDead) {
			Dead ();
		}
	}

	public virtual void Hurt (int damage) {
		if (!isDead) {
			health -= damage;
		}
	}

	public virtual void Hurt (int damage, Transform attackPosition) {
		if (!isDead) {
			health -= damage;
		}
	}

	protected virtual void Dead () {
		isDead = true;
	}
}