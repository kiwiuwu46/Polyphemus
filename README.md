# Template .NET Project

## Description

## Steps after creating new repository

1. Rename Solution.sln, Solution.code-workspace and Solution.sln.DotSettings to the name of your project (e.g. MyProject.sln, MyProject.code-workspace and MyProject.sln.DotSettings)
1. Edit src/Directory.Build.props and replace the 2 urls with the url of your new repository
2. When adding test projects, edit the csproj and remove Version="" from the PackageReference tags.

## When writing commits, use the following rules

Anything after #1 is optional

1. (Optional emoji from https://gitmoji.dev/) Short description of the change (max 50 chars)
   1. Always in the present tense, starting with a verb
2. Blank line
3. Extended description (max 72 chars per line)
   1. This should provide context for the change
   2. This should explain why the change is being made
   3. This should explain how the change addresses the issue (if applicable)
   4. This should provide any other information that is useful for the reviewer
4. Blank line
5. Links
   1. Issue references '#240'
   2. Issue resolutions 'Resolves #240'
   3. Additional authors
