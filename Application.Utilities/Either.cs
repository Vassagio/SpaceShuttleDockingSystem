using System;

namespace Application.Utilities
{
	public abstract class Either<TElect, TSkip>
	{
		public static implicit operator Either<TElect, TSkip>(TElect elect) => new EitherElect<TElect, TSkip>(elect);

		public static implicit operator Either<TElect, TSkip>(TSkip skip) => new EitherSkip<TElect, TSkip>(skip);

		public abstract void Handle(Action<TElect> elect, Action<TSkip> skip);
		public abstract TResult Handle<TResult>(Func<TElect, TResult> elect, Func<TSkip, TResult> skip);
	}
}