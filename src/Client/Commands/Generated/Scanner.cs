// Generated on Wed May 29 2024 using @salesforce/cli/2.42.6 win32-x64 node-v20.12.2. DO NOT MODIFY

using sfdx4csharp.Client.Core;
using sfdx4csharpClient.Core;
using sfdx4csharpClient.Core.Attributes;

namespace sfdx4csharpClient
{
    /// <summary>
    /// Options for the method RuleAdd of class Scanner.
    /// </summary>
    public class ScannerRuleAddOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] One or more paths (such as a directory or JAR file) to custom rule definitions. Specify multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }

        /// <summary>
        /// [Required] Language that the custom rules are evaluated against.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }
    }

    /// <summary>
    /// Options for the method RuleDescribe of class Scanner.
    /// </summary>
    public class ScannerRuleDescribeOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Required] The name of the rule.
        /// </summary>
        [SwitchName("--rulename")]
        public string Rulename { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Emit additional command output to stdout.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] Uses PMD version 7.0.0-rc4 instead of 6.55.0 to describe PMD and CPD rules.
        /// </summary>
        [SwitchName("--preview-pmd7")]
        public bool? PreviewPmd7 { get; set; }
    }

    /// <summary>
    /// Options for the method RuleList of class Scanner.
    /// </summary>
    public class ScannerRuleListOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Emit additional command output to stdout.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Required] Selects rules by category. Enter multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--category")]
        public string Category { get; set; }

        /// <summary>
        /// [Required] Deprecated. Use category instead. Selects rules by ruleset. Enter multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--ruleset")]
        public string Ruleset { get; set; }

        /// <summary>
        /// [Required] Selects rules by language. Enter multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--language")]
        public string Language { get; set; }

        /// <summary>
        /// [Required] Selects rules by engine. Enter multiple engines as a comma-separated list.
        /// </summary>
        [SwitchName("--engine")]
        public string Engine { get; set; }

        /// <summary>
        /// [Optional] Uses PMD version 7.0.0-rc4 instead of 6.55.0 to list PMD and CPD rules.
        /// </summary>
        [SwitchName("--preview-pmd7")]
        public bool? PreviewPmd7 { get; set; }
    }

    /// <summary>
    /// Options for the method RuleRemove of class Scanner.
    /// </summary>
    public class ScannerRuleRemoveOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Emit additional command output to stdout.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Optional] Bypasses the confirmation prompt and immediately removes the rules.
        /// </summary>
        [SwitchName("--force")]
        public bool? Force { get; set; }

        /// <summary>
        /// [Required] One or more paths to remove. Specify multiple values with a comma-separated list.
        /// </summary>
        [SwitchName("--path")]
        public string Path { get; set; }
    }

    /// <summary>
    /// Options for the method Run of class Scanner.
    /// </summary>
    public class ScannerRunOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Emit additional command output to stdout.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Required] One or more categories of rules to run. Specify multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--category")]
        public string Category { get; set; }

        /// <summary>
        /// [Required] Specifies the output format for results written directly to the console.
        /// </summary>
        [SwitchName("--format")]
        public string Format { get; set; }

        /// <summary>
        /// [Required] Writes output to a file.
        /// </summary>
        [SwitchName("--outfile")]
        public string Outfile { get; set; }

        /// <summary>
        /// [Required] Throws an error when violations are found with equal or greater severity than the provided value. Values are 1 (high), 2 (moderate), and 3 (low). Exit code is the most severe violation. Using this flag also invokes the --normalize-severity flag.
        /// </summary>
        [SwitchName("--severity-threshold")]
        public string SeverityThreshold { get; set; }

        /// <summary>
        /// [Optional] Returns normalized severity 1 (high), 2 (moderate), and 3 (low), and the engine-specific severity. For the html option, the normalized severity is displayed instead of the engine severity.
        /// </summary>
        [SwitchName("--normalize-severity")]
        public bool? NormalizeSeverity { get; set; }

        /// <summary>
        /// [Required] Provides the relative or absolute root project directories used to set the context for Graph Engine's analysis. Specify multiple values as a comma-separated list. Each project directory must be a path, not a glob. If --projectdir isn’t specified, a default value is calculated. The default value is a directory that contains all the target files.
        /// </summary>
        [SwitchName("--projectdir")]
        public string Projectdir { get; set; }

        /// <summary>
        /// [Required] Deprecated. Use category instead. One or more rulesets to run. Specify multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--ruleset")]
        public string Ruleset { get; set; }

        /// <summary>
        /// [Required] Specifies one or more engines to run. Submit multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--engine")]
        public string Engine { get; set; }

        /// <summary>
        /// [Required] Specifies the source code location. Can use glob patterns. Specify multiple values as a comma-separated list. Default is ".".
        /// </summary>
        [SwitchName("--target")]
        public string Target { get; set; }

        /// <summary>
        /// [Required] The location of the tsconfig.json file used by the eslint-typescript engine. The --tsconfig flag can’t be used with --eslintconfig flag.
        /// </summary>
        [SwitchName("--tsconfig")]
        public string Tsconfig { get; set; }

        /// <summary>
        /// [Required] Specifies the location of eslintrc config to customize ESLint engine. The --tsconfig flag can’t be used with --eslintconfig flag.
        /// </summary>
        [SwitchName("--eslintconfig")]
        public string Eslintconfig { get; set; }

        /// <summary>
        /// [Required] Specifies the location of the PMD rule reference XML file to customize rule selection.
        /// </summary>
        [SwitchName("--pmdconfig")]
        public string Pmdconfig { get; set; }

        /// <summary>
        /// [Optional] Uses PMD version 7.0.0-rc4 instead of 6.55.0 when running PMD and CPD engines.
        /// </summary>
        [SwitchName("--preview-pmd7")]
        public bool? PreviewPmd7 { get; set; }

        /// <summary>
        /// [Required] Deprecated. Overrides ESLint's default environmental variables, in JSON-formatted string.
        /// </summary>
        [SwitchName("--env")]
        public string Env { get; set; }

        /// <summary>
        /// [Optional] Returns retire-js violation-message details about each vulnerability, including summary, common vulnerabilities and exposures (CVE), and URLs.
        /// </summary>
        [SwitchName("--verbose-violations")]
        public bool? VerboseViolations { get; set; }
    }

    /// <summary>
    /// Options for the method RunDfa of class Scanner.
    /// </summary>
    public class ScannerRunDfaOptions : SfdxOptions
    {
        /// <summary>
        /// [Required] Raw string parameters for the command. EX: 'name=value' expressions or parameters without flags.
        /// </summary>
        [SwitchName("")]
        public string Expression { get; set; }

        /// <summary>
        /// [Optional] Format output as json.
        /// </summary>
        [SwitchName("--json")]
        public bool? Json { get; set; }

        /// <summary>
        /// [Optional] Emit additional command output to stdout.
        /// </summary>
        [SwitchName("--verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// [Required] One or more categories of rules to run. Specify multiple values as a comma-separated list.
        /// </summary>
        [SwitchName("--category")]
        public string Category { get; set; }

        /// <summary>
        /// [Required] Specifies the output format for results written directly to the console.
        /// </summary>
        [SwitchName("--format")]
        public string Format { get; set; }

        /// <summary>
        /// [Required] Writes output to a file.
        /// </summary>
        [SwitchName("--outfile")]
        public string Outfile { get; set; }

        /// <summary>
        /// [Required] Throws an error when violations are found with equal or greater severity than the provided value. Values are 1 (high), 2 (moderate), and 3 (low). Exit code is the most severe violation. Using this flag also invokes the --normalize-severity flag.
        /// </summary>
        [SwitchName("--severity-threshold")]
        public string SeverityThreshold { get; set; }

        /// <summary>
        /// [Optional] Returns normalized severity 1 (high), 2 (moderate), and 3 (low), and the engine-specific severity. For the html option, the normalized severity is displayed instead of the engine severity.
        /// </summary>
        [SwitchName("--normalize-severity")]
        public bool? NormalizeSeverity { get; set; }

        /// <summary>
        /// [Required] Provides the relative or absolute root project directories used to set the context for Graph Engine's analysis. Specify multiple values as a comma-separated list. Each project directory must be a path, not a glob. If --projectdir isn’t specified, a default value is calculated. The default value is a directory that contains all the target files.
        /// </summary>
        [SwitchName("--projectdir")]
        public string Projectdir { get; set; }

        /// <summary>
        /// [Optional] Allows pilot rules to execute.
        /// </summary>
        [SwitchName("--with-pilot")]
        public bool? WithPilot { get; set; }

        /// <summary>
        /// [Required] Specifies the source code location. Use glob patterns or specify individual methods with #-syntax. Multiple values are specified as a comma-separated list. Default is ".".
        /// </summary>
        [SwitchName("--target")]
        public string Target { get; set; }

        /// <summary>
        /// [Required] Specifies the number of rule-evaluation threads or how many entry points can be evaluated concurrently. Inherits its value from the SFGE_RULE_THREAD_COUNT environment variable, if set. The default is 4.
        /// </summary>
        [SwitchName("--rule-thread-count")]
        public string RuleThreadCount { get; set; }

        /// <summary>
        /// [Required] Specifies the time limit for evaluating a single entry point in milliseconds. Inherits its value from the SFGE_RULE_THREAD_TIMEOUT environment variable, if set. The default is 900,000 ms or 15 minutes.
        /// </summary>
        [SwitchName("--rule-thread-timeout")]
        public string RuleThreadTimeout { get; set; }

        /// <summary>
        /// [Optional] Disables warning violations, such as those on StripInaccessible READ access, to get only high-severity violations (default: false). Inherits value from SFGE_RULE_DISABLE_WARNING_VIOLATION env-var if set.
        /// </summary>
        [SwitchName("--rule-disable-warning-violation")]
        public bool? RuleDisableWarningViolation { get; set; }

        /// <summary>
        /// [Required] Specifies Java Virtual Machine arguments to override system defaults while executing Salesforce Graph Engine. For multiple arguments, add them to the same string separated by space.
        /// </summary>
        [SwitchName("--sfgejvmargs")]
        public string Sfgejvmargs { get; set; }

        /// <summary>
        /// [Required] Specifies a path expansion upper boundary to limit the complexity of code Graph Engine analyzes before failing fast. Set the value to -1 to remove any upper boundary. --pathexplimit inherits value from SFGE_PATH_EXPANSION_LIMIT env-var, if set. Its default value is derived from JVM heap space allocation.
        /// </summary>
        [SwitchName("--pathexplimit")]
        public string Pathexplimit { get; set; }
    }

    /// <summary>
    /// Scanner
    /// </summary>
    [CommandClass("scanner")]
    public class Scanner : SfdxCommand
    {
        /// Constructor.
        public Scanner(CommandExecutioner commandExecutioner)
                : base(commandExecutioner)
        {
        }

        /// <summary>
        /// Adds custom rules to Salesforce Code Analyzer's registry so that you can run them along with the built-in rules. Compile and test custom rules separately before adding them.
        /// </summary>
        /// <remarks>
        /// Adds custom rules to Salesforce Code Analyzer's registry so that you can run them along with the built-in rules. Compile and test custom rules separately before adding them.
        /// </remarks>
        /// <example>
        /// 
        /// Bundle custom PMD rules in JAR files. Follow PMD conventions, such as defining the custom rules in XML files under a `/category/` directory.
        /// See PMD's documentation for more information on writing rules.
        /// 
        /// This example shows how to specify two JAR files directly.
        /// 	$ <%= config.bin %> <%= command.id %> --language apex --path "/Users/me/rules/Jar1.jar,/Users/me/rules/Jar2.jar"
        /// 		Successfully added rules for apex.
        /// 		2 path(s) added:
        /// 		/Users/me/rules/Jar1.jar,/Users/me/rules/Jar2.jar
        /// 
        /// This example shows how to specify a directory containing one or more JARs, all of which are added to the registry.
        /// 	$ <%= config.bin %> <%= command.id %> --language apex --path "/Users/me/rules"
        /// 		Successfully added rules for apex.
        /// </example>
        [Command("rule add")]
        public SfdxResponse RuleAdd(ScannerRuleAddOptions options)
        {
            return ExecuteCommand(nameof(RuleAdd), options);
        }

        /// <summary>
        /// Provides detailed information about a rule. Information includes the rule's language (such as Apex or Java), the violation it detects, and example code of the violation. The command output also includes the rule's categories and rulesets.
        /// </summary>
        /// <remarks>
        /// Provides detailed information about a rule. Information includes the rule's language (such as Apex or Java), the violation it detects, and example code of the violation. The command output also includes the rule's categories and rulesets.
        /// </remarks>
        /// <example>
        /// 
        /// $ <%= config.bin %> <%= command.id %> --rulename ExampleRule
        /// 	name:        AvoidWithStatement
        /// 	categories:   Best Practices
        /// 	rulesets:    Controversial Ecmascript
        /// 	languages:   javascript
        /// 	description: Avoid using with - it's bad news
        /// 	message:     Avoid using with - it's bad news
        /// </example>
        [Command("rule describe")]
        public SfdxResponse RuleDescribe(ScannerRuleDescribeOptions options)
        {
            return ExecuteCommand(nameof(RuleDescribe), options);
        }

        /// <summary>
        /// Lists all the rules available in the catalog. You can filter the output to view a smaller set of rules. To get more information about a specific rule, use the `scanner rule describe` command.
        /// </summary>
        /// <remarks>
        /// Lists all the rules available in the catalog. You can filter the output to view a smaller set of rules. To get more information about a specific rule, use the `scanner rule describe` command.
        /// </remarks>
        /// <example>
        /// 
        /// This example invokes the command without filter criteria, which returns all rules.
        /// 	$ <%= config.bin %> <%= command.id %>
        /// 
        /// This example returns all rules for Apex OR Javascript. Values supplied to a single filter are handled with a logical OR.
        /// 	$ <%= config.bin %> <%= command.id %> --language apex,javascript
        /// 
        /// This example returns all rules except those in the Design or Best Practices categories. Exclude categories by specifying the negation operator and enclosing the values in single quotes.
        /// 	$ <%= config.bin %> <%= command.id %> --category '!Design,!Best Practices'
        /// 
        /// This example returns all rules that target Apex OR Javascript, AND are members of the Braces OR Security rulesets.
        /// The different filters are combined with a logical AND.
        /// 	$ <%= config.bin %> <%= command.id %> --language apex,javascript --ruleset Braces,Security
        /// </example>
        [Command("rule list")]
        public SfdxResponse RuleList(ScannerRuleListOptions options)
        {
            return ExecuteCommand(nameof(RuleList), options);
        }

        /// <summary>
        /// Removes custom rules from the registry of available rules. Use the `-p|--path` parameter to specify one or more paths to remove. If you don't specify any parameters, the command lists all valid custom paths but doesn't remove any.
        /// </summary>
        /// <remarks>
        /// Removes custom rules from the registry of available rules. Use the `-p|--path` parameter to specify one or more paths to remove. If you don't specify any parameters, the command lists all valid custom paths but doesn't remove any.
        /// </remarks>
        /// <example>
        /// 
        /// This example runs the command without arguments to see a list of registered custom paths.
        /// 	$ <%= config.bin %> <%= command.id %>
        /// 
        /// This example uses the --path parameter to deregister the rules defined in somerules.jar and any JARs/XMLs contained in the rules folder.
        /// 	$ <%= config.bin %> <%= command.id %> --path "~/path/to/somerules.jar,~/path/to/folder/containing/rules"
        /// 
        /// This example uses the --force flag to bypass the confirmation prompt, removing all rules defined in somerules.jar.
        /// By default, a list of all rules that will be unregistered is displayed, and the action must be confirmed. To bypass that confirmation, use the --force flag.
        /// 	$ <%= config.bin %> <%= command.id %> --force --path "~/path/to/somerules.jar"
        /// </example>
        [Command("rule remove")]
        public SfdxResponse RuleRemove(ScannerRuleRemoveOptions options)
        {
            return ExecuteCommand(nameof(RuleRemove), options);
        }

        /// <summary>
        /// Scans a codebase with a selection of rules. You can scan the codebase with all the rules in the registry, or use parameters to filter the rules based on rulename, category, or ruleset. You can specify the format of the output, such as XML or JUnit. You can print the output to the console (default) or to a file using the --outfile parameter.
        /// </summary>
        /// <remarks>
        /// Scans a codebase with a selection of rules. You can scan the codebase with all the rules in the registry, or use parameters to filter the rules based on rulename, category, or ruleset. You can specify the format of the output, such as XML or JUnit. You can print the output to the console (default) or to a file using the --outfile parameter.
        /// </remarks>
        /// <example>
        /// 
        /// This example evaluates all rules against somefile.js.
        /// Invoking code analyzer without specifying any rules causes all rules to be run.
        /// 	$ <%= config.bin %> <%= command.id %> --format xml --target "somefile.js"
        /// 
        /// This example evaluates all rules in the Design and Best Practices categories.
        /// When you specify multiple categories or rulesets, the results are combined with a logical OR.
        /// 	$ <%= config.bin %> <%= command.id %> --format xml --target "somefile.js" --
        /// 
        /// This example evaluates all rules except those in the Design or Best Practices categories.
        /// Exclude categories by specifying the negation operator and enclosing the values in single quotes.
        /// 	$ <%= config.bin %> <%= command.id %> --format xml --target "somefile.js" --category '!Design,!Best Practices'
        /// 
        /// Wrap globs in quotes. These examples evaluate rules against all .js files in the current directory, except for IgnoreMe.js.
        /// Unix example:
        /// 	$ <%= config.bin %> <%= command.id %> --target './** /*.js,!./** /IgnoreMe.js' ...
        /// Windows example:
        /// 	$ <%= config.bin %> <%= command.id %> --target ".\**\*.js,!.\**\IgnoreMe.js" ...
        /// 
        /// This example scans the project contained in '/my-project' if the current working directory is another directory.
        /// Specify tsconfig.json if the current working directory does not contain the tsconfig.json that corresponds to the TypeScript files being scanned.
        /// 	$ <%= config.bin %> <%= command.id %> --target "/my-project/** /*.ts" --tsconfig "/my-project/tsconfig.json"
        /// 
        /// This example evaluates rules against somefile.js, including Jasmine in the environment variables.
        /// Uses --env to override the default ESLint environment variables to add frameworks.
        /// 	$ <%= config.bin %> <%= command.id %> --target "somefile.js" --env '{"jasmine": true}'
        /// 
        /// This example evaluates rules aginst somefile.js using eslint-lwc and pmd engines.
        /// Use --engine to include or exclude engines. Any engine listed will be run, regardless of its current 'disabled' attribute.
        /// 	$ <%= config.bin %> <%= command.id %> --target "somefile.js" --engine "eslint-lwc,pmd"
        /// 
        /// This example executes CPD engine against known file extensions in "/some/dir". CPD helps detect blocks of code duplication in selected languages.
        /// Use --engine to invoke engines that are not enabled by default.
        /// 	$ <%= config.bin %> <%= command.id %> --target "/some/dir" --engine cpd
        /// 
        /// This example executes rules defined in pmd_rule_ref.xml against the files in 'src'.
        /// To use PMD with your own rule reference file, use --pmdconfig. Note that rule filters are not applied.
        /// 	$ <%= config.bin %> <%= command.id %> --target "src" --pmdconfig "pmd_rule_ref.xml"
        /// 
        /// This example uses a custom config to scan the files in 'src'.
        /// To use ESLint with your own .eslintrc.json file, use --eslintconfig. Make sure that the directory you run the command from has all the NPM dependencies installed.
        /// 	$ <%= config.bin %> <%= command.id %> --target "src" --eslintconfig "/home/my/setup/.eslintrc.json"
        /// 
        /// This example uses --normalize-severity to output normalized severity and engine-specific severity across all engines. Normalized severity is: 1 (high), 2 (moderate), and 3 (low).
        /// 	$ <%= config.bin %> <%= command.id %> --target "/some-project/" --format csv --normalize-severity
        /// 
        /// This example uses --severity-threshold to throw a non-zero exit code when rule violations of normalized severity 2 or greater are found. If any violations with the specified severity (or greater) are found, the exit code equals the severity of the most severe violation.
        /// 	$ <%= config.bin %> <%= command.id %> --target "/some-project/" --severity-threshold 2
        /// 
        /// The paths specified for --projectdir must contain all files specified through --target cumulatively.
        /// 	$ <%= config.bin %> <%= command.id %> --target "./myproject/main/default/classes/*.cls" --projectdir "./myproject/"
        /// 	$ <%= config.bin %> <%= command.id %> --target "./** /*.cls" --projectdir "./"
        /// 	$ <%= config.bin %> <%= command.id %> --target "./dir1/file1.cls,./dir2/file2.cls" --projectdir "./dir1/,./dir2/"
        /// 
        /// This example fails because the set of files included in --target is larger than that contained in --projectdir:
        /// 	$ <%= config.bin %> <%= command.id %> --target "./** /*.cls" --projectdir "./myproject/"
        /// </example>
        [Command("run")]
        public SfdxResponse Run(ScannerRunOptions options)
        {
            return ExecuteCommand(nameof(Run), options);
        }

        /// <summary>
        /// Scans codebase with all DFA rules by default.
        /// 	Specify the format of output and print results directly or as contents of a file that you provide with --outfile flag.
        /// </summary>
        /// <remarks>
        /// Scans codebase with all DFA rules by default.
        /// 	Specify the format of output and print results directly or as contents of a file that you provide with --outfile flag.
        /// </remarks>
        /// <example>
        /// 
        /// The paths specified for --projectdir must contain all files specified through --target cumulatively.
        /// 	$ <%= config.bin %> <%= command.id %> --target "./myproject/main/default/classes/*.cls" --projectdir "./myproject/"
        /// 	$ <%= config.bin %> <%= command.id %> --target "./** /*.cls" --projectdir "./"
        /// 	$ <%= config.bin %> <%= command.id %> --target "./dir1/file1.cls,./dir2/file2.cls" --projectdir "./dir1/,./dir2/"
        /// This example fails because the set of files included in --target is larger than that contained in --projectdir:
        /// 	$ <%= config.bin %> <%= command.id %> --target "./** /*.cls" --projectdir "./myproject/"
        /// Globs must be wrapped in quotes, as in these Windows and Unix examples, which evaluate rules against all .cls files in the current directory and subdirectories except for IgnoreMe.cls:
        /// Unix example:
        /// 	$ <%= config.bin %> <%= command.id %> --target "./** /*.cls,!./** /IgnoreMe.cls" ...
        /// Windows example:
        /// 	$ <%= config.bin %> <%= command.id %> --target ".\**\*.cls,!.\**\IgnoreMe.cls" ...
        /// You can target individual methods within a file with a suffix hash (#) on the file's path, and with a semi-colon-delimited list of method names. This syntax is incompatible with globs and directories. This example evaluates rules against all methods named Method1 or Method2 in File1.cls, and all methods named Method3 in File2.cls:
        /// 	$ <%= config.bin %> <%= command.id %> --target "./File1.cls#Method1;Method2,./File2.cls#Method3" ...
        /// Use --normalize-severity to output a normalized severity across all engines, in addition to the engine-specific severity. Normalized severity is 1 (high), 2 (moderate), and 3 (low):
        /// 	$ <%= config.bin %> <%= command.id %> --target "./some-project/" --projectdir "./some-project/" --format csv --normalize-severity
        /// Use --severity-threshold to throw a non-zero exit code when rule violations of a specific normalized severity or greater are found. If there are any rule violations with a severity of 2 or 1, the exit code is equal to the severity of the most severe violation:
        /// 	$ <%= config.bin %> <%= command.id %> --target "./some-project/" --projectdir "./some-project/" --severity-threshold 2
        /// use --rule-thread-count to allow more (or fewer) entrypoints to be evaluated concurrently:
        /// 	$ <%= config.bin %> <%= command.id %> --rule-thread-count 6 ...
        /// Use --rule-thread-timeout to increase or decrease the maximum runtime for a single entrypoint evaluation. This increases the timeout from the 15-minute default to 150 minutes:
        /// 	$ <%= config.bin %> <%= command.id %> --rule-thread-timeout 9000000 ...
        /// Use --sfgejvmargs to pass Java Virtual Machine args to override system defaults while executing Salesforce Graph Engine's rules.
        /// The example overrides the system's default heap space allocation to 8 GB and decreases chances of encountering OutOfMemory error.
        /// 	$ <%= config.bin %> <%= command.id %> --sfgejvmargs "-Xmx8g" ...
        /// Use --with-pilot to allow execution of pilot rules:
        /// This example allows pilot rules in the "Performance" category to execute.
        /// 	$ <%= config.bin %> <%= command.id %> --category 'Performance' --with-pilot ...
        /// </example>
        [Command("run dfa")]
        public SfdxResponse RunDfa(ScannerRunDfaOptions options)
        {
            return ExecuteCommand(nameof(RunDfa), options);
        }
    }
}
