using System;

namespace Application.Utilities
{
	public sealed class EitherElect<TElect, TSkip> : Either<TElect, TSkip>
	{
		private readonly TElect _value;

		public EitherElect(TElect value) => _value = value;

		public override void Handle(Action<TElect> elect, Action<TSkip> skip) => elect(_value);
		public override TResult Handle<TResult>(Func<TElect, TResult> elect, Func<TSkip, TResult> skip) => elect(_value);
	}
}