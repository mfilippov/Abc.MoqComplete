﻿using System.Collections.Generic;
using Abc.MoqComplete.Services;
using Abc.MoqComplete.Services.MethodProvider;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace Abc.MoqComplete.CompletionProvider
{
	[Language(typeof(CSharpLanguage))]
	public class ReturnsMethodProvider : BaseReturnsMethodProvider
	{
        protected override IMethod GetMockedMethodFromSetupMethod(ISolution solution, IInvocationExpression invocation)
		{
			var methodProvider = solution.GetComponent<IMockedMethodProvider>();

			return methodProvider.GetMockedMethodFromSetupMethod(invocation);
		}
        
		protected override IEnumerable<string> GetMockedMethodParameterTypes(ISolution solution, IInvocationExpression invocation)
		{
			var methodProvider = solution.GetComponent<IMockedMethodProvider>();

			return methodProvider.GetMockedMethodParameterTypes(invocation);
		}
	}
}