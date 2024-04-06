using UnityEngine;

namespace HDyar.WeightedRandomUtility
{
	[System.Serializable]
	public class WeightedItem<T>
	{
		public T item;
		[Min(0)] public float weight = 0;
		public AnimationCurve Curve = AnimationCurve.Linear(0,0,1,1);
		public void SetWeightByCurve(float x)
		{
			weight = Curve.Evaluate(x);
		}
	}
}