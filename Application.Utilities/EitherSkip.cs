using System;

namespace Application.Utilities
{
	public sealed class EitherSkip<TElect, TSkip> : Either<TElect, TSkip>
	{
		private readonly TSkip _value;

		public EitherSkip(TSkip value) => _value = value;

		public override void Handle(Action<TElect> elect, Action<TSkip> skip) => skip(_value);
		public override TResult Handle<TResult>(Func<TElect, TResult> elect, Func<TSkip, TResult> skip) => skip(_value);
	}
}