using UnityEngine;

namespace HDyar.WeightedRandomUtility
{
	[System.Serializable]
	public class WeightedItem<T>
	{
		public T item;
		public float Weight => GetWeight(1);//todo: decide how the optional curve should be enabled or disabled.
		[Min(0), SerializeField] float weight = 0;
		public AnimationCurve Curve = AnimationCurve.Linear(0,1,1,1);
		
		//This setup assumes curve is a 0-1 range.
		public float GetWeight(float curveValue)
		{
			return weight * Curve.Evaluate(curveValue);
		}
		//This setup assumed curve outputting the weight directly, and was how I did zoomycat.
		//It probably makes more sense to think of the curbe as a 0-1 easing function, for generic use.
		public void SetWeightByCurve(float x)
		{
			weight = Curve.Evaluate(x);
		}
	}
}