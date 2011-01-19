using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Parsing;

namespace BizTalk.Grammars
{

    public class XLANGsGrammar : Grammar
    {
        TerminalSet _skipTokensInPreview = new TerminalSet(); //used in token preview for conflict resolution

        public XLANGsGrammar()
        {
            var xlang_orchestration = new NonTerminal("orchestration");
            var xlang_module = new NonTerminal("module");
            var xlang_module_identifier = new NonTerminal("module_identifier");
            var xlang_operators = new NonTerminal("operators");
            var xlang_type_definitions = new NonTerminal("type_definitions");
            var xlang_type_definition_att_opt = new NonTerminal("type_definition_att?");
            var xlang_type_definition = new NonTerminal("type_definition");
            var xlang_type_definition_choice = new NonTerminal("type_definition_choice");
            var xlang_servicetype_definition = new NonTerminal("service_type_definition");
            var xlang_servicetype_definitions = new NonTerminal("servicetype_definitions");
            var xlang_accesmodifier_choice = new NonTerminal("accesmodifier_choice");
            var xlang_mep_choice = new NonTerminal("mep_choice");
            var xlang_body = new NonTerminal("body");
            var xlang_exceptions = new NonTerminal("exceptions");
            var xlang_exceptions_opt = new NonTerminal("exceptions?");
            var xlang_catch_clauses = new NonTerminal("catch_clauses");
            var xlang_catch_clause_att_opt = new NonTerminal("catch_clause_att?");
            var xlang_compensation = new NonTerminal("compensation");
            var xlang_compensation_opt = new NonTerminal("compensation?");
            var xlang_transaction_declaration_opt = new NonTerminal("transaction_declaration?");
            var xlang_transaction_declaration = new NonTerminal("transaction_declaration");
            var xlang_transaction_type_opt = new NonTerminal("transaction_type?");
            var xlang_transaction_type_choice = new NonTerminal("transaction_type_choice");
            var xlang_messagetypes = new NonTerminal("messagetypes");
            var xlang_messagetype_definition = new NonTerminal("messagetype_definition");
            var xlang_message_parts = new NonTerminal("message_parts");
            var xlang_body_part = new NonTerminal("body_part");
            var xlang_messagepart_choice = new NonTerminal("messagepart_choice");
            var xlang_porttype_definitions = new NonTerminal("porttype_definitions");
            var xlang_porttype_definition = new NonTerminal("porttype_definition");
            var xlang_porttype_operations = new NonTerminal("porttype_operations");
            var xlang_porttype_operation = new NonTerminal("porttype_operation");
            var xlang_operation_messagetypes = new NonTerminal("operation_messagetypes");
            var xlang_operation_messagetype_choice = new NonTerminal("operation_messagetype_choice");
            var xlang_operation_fault_messagetype = new NonTerminal("operation_fault_messagetype");
            var xlang_correlationtypes = new NonTerminal("correlationtypes");
            var xlang_correlationtype_definition = new NonTerminal("correlationtype_definition");
            var xlang_servicelinktypes = new NonTerminal("servicelinktypes");
            var xlang_servicelinktype_definition = new NonTerminal("servicelinktype_definition");
            var xlang_type_choice = new NonTerminal("type_choice");
            var xlang_porttype = new NonTerminal("porttype");
            var xlang_correlationtype = new NonTerminal("correlationtype");
            var xlang_messagetype = new NonTerminal("messagetype");
            var xlang_servicelinktype = new NonTerminal("servicelinktype");
            var xlang_port_direction = new NonTerminal("port_direction");
            var xlang_scope = new NonTerminal("scope");
            var xlang_correlation_properties = new NonTerminal("correlation_properties");
            var xlang_nonbody_part = new NonTerminal("nonbody_part");
            var xlang_operation_messagetype = new NonTerminal("operation_messagetype");

            var xlang_call_statement = new NonTerminal("call_statement");
            var xlang_exec_statement = new NonTerminal("exec_statement");

            var xlang_statement_choice = new NonTerminal("statement");
            var xlang_statement_att_opt = new NonTerminal("statement_att?");
            var xlang_statement_list = new NonTerminal("statement_list");
            var xlang_task = new NonTerminal("task");
            var xlang_tasks = new NonTerminal("tasks");
            var xlang_parallel = new NonTerminal("parallel");
            var xlang_send_statement = new NonTerminal("send_statement");
            var xlang_receive = new NonTerminal("receive");
            var xlang_receive_statement = new NonTerminal("receive_statement");
            var xlang_suspend_statement = new NonTerminal("suspend_statement");
            var xlang_terminate_statement = new NonTerminal("terminate_statement");
            var xlang_construct = new NonTerminal("construct");
            var xlang_message_identifiers = new NonTerminal("message_identifiers");
            var xlang_construct_choice = new NonTerminal("construct_choice");
            var xlang_transform_statement = new NonTerminal("transform_statement");
            var xlang_construct_statements = new NonTerminal("construct_statements");
            var xlang_construct_choice_att_opt = new NonTerminal("construct_choice_att?");
            var xlang_receive_branch = new NonTerminal("receive_branch");
            var xlang_timeout_branch = new NonTerminal("timeout_branch");
            var xlang_listen = new NonTerminal("listen");
            var xlang_listen_choice = new NonTerminal("listen_choice");
            var xlang_listen_branch_att_opt = new NonTerminal("listen_branch_att?");
            var xlang_listen_branches = new NonTerminal("listen_branches");
            var xlang_delay = new NonTerminal("delay");
            var xlang_delay_statement = new NonTerminal("delay_statement");
            var xlang_limited_object_creation_expression = new NonTerminal("limited_object_creation_expression");
            var xlang_timespan_returning_expression = new NonTerminal("timespan_returning_expression");
            var xlang_activate_opt = new NonTerminal("activate?");
            var xlang_scope_statement_att_opt = new NonTerminal("scope_statement_att?");
            var xlang_scope_statements = new NonTerminal("scope_statements");
            var xlang_scope_statements_opt = new NonTerminal("scope_statements?");
            var xlang_scope_implementation = new NonTerminal("scope_impl");
            var xlang_module_att_opt = new NonTerminal("module_att?");
            var xlang_longrunning_transaction = new NonTerminal("lr_transaction");
            var xlang_atomic_transaction = new NonTerminal("atomic_transaction");
            var xlang_scope_statement_choice = new NonTerminal("scope_statement_choice");
            var xlang_formal_parameters_par_opt = new NonTerminal("formal_parameter_list_par?");
            var xlang_roletypes = new NonTerminal("roletypes");
            var xlang_roletype = new NonTerminal("roletype");
            var xlang_receive_operation = new NonTerminal("receive_operation");
            var xlang_follow_correlation = new NonTerminal("follow_correlation");
            var xlang_initialize_correlation = new NonTerminal("initialize_correlation");
            var xlang_correlation_arg_choice = new NonTerminal("correlation_args");
            var xlang_correlation_args = new NonTerminal("correlation_args");
            var xlang_correlation_args_opt = new NonTerminal("correlation_args?");
            var xlang_receive_arguments = new NonTerminal("receive_arguments");
            var xlang_send_arguments = new NonTerminal("send_arguments");
            var xlang_exists_expression_short = new NonTerminal("exists_expression");
            var xlang_xpath_expression_short = new NonTerminal("xpath_expression_short");
            var xlang_xpath_expression_long = new NonTerminal("xpath_expression_long");
            var xlang_xpath_expression_choice = new NonTerminal("xpath_expression_choice");
            var xlang_property_reference = new NonTerminal("property_reference");
            var xlang_exists_expression_choice = new NonTerminal("exists_expression_choice");
            var xlang_exists_expression_message_reference = new NonTerminal("exists_expression_message_reference");
            var xlang_exists_expression_message_part_reference = new NonTerminal("exists_expression_message_part_reference");
            var xlang_intrinsic_expression = new NonTerminal("intrinsic_expression");
            var xlang_message_reference = new NonTerminal("message_reference");
            var xlang_message_part_reference = new NonTerminal("messagepart_reference");
            var xlang_message_or_message_part_reference_choice = new NonTerminal("xlang_message_or_message_part_reference");

            var xlang_message_identifier = TerminalFactory.CreateCSharpIdentifier("message_identifier");
            var xlang_messagepart_identifier = TerminalFactory.CreateCSharpIdentifier("messagepart_identifier");
            var xlang_messagetype_identifier = TerminalFactory.CreateCSharpIdentifier("message_type_identifier");
            var xlang_porttype_identifier = TerminalFactory.CreateCSharpIdentifier("port_type_identifier");
            var xlang_operation_identifier = TerminalFactory.CreateCSharpIdentifier("port_operation_identifier");
            var xlang_correlationtype_identifier = TerminalFactory.CreateCSharpIdentifier("correlation_type_identifier");
            var xlang_servicelinktype_identifier = TerminalFactory.CreateCSharpIdentifier("servicelink_type_identifier");
            var xlang_transaction_identifier = TerminalFactory.CreateCSharpIdentifier("transaction_identifier");
            var xlang_roletype_identifier = TerminalFactory.CreateCSharpIdentifier("roletype_identifier");

            //Temporarily, treat preprocessor instructions like comments
            CommentTerminal ppInstruction = new CommentTerminal("ppInstruction", "#", "\n");
            NonGrammarTerminals.Add(ppInstruction);

            //ignore designer data, must be below above rule for preprocessor
            var designer_data = new CommentTerminal("designer_data", "#if __DESIGNER_DATA", "#endif");
            NonGrammarTerminals.Add(designer_data);

            this.MarkReservedWords("activate", "atomic", "body", "call", "catch",
            "checked", "compensate", "compensation", "construct", "correlation", "correlationtype", "delay", "dynamic", "else", "exceptions", "exec",
            "exists", "false", "if", "implements", "in", "initialize", "internal", "link", "listen", "longrunning", "message", "messagetype", "method",
            "module", "new", "null", "oneway", "out", "parallel", "port", "porttype", "private", "public", "receive", "ref", "request", "requestresponse",
            "response", "scope", "send", "service", "servicelink", "servicelinktype", "source", "suppressfailure", "suspend", "succeeded", "target", "task",
            "terminate", "throw", "timeout", "transaction", "transform", "true", "unchecked", "until", "uses", "using", "while", "xpath");

            #region CSharp

            #region Comments
            //copy of c-sharp comments
            CommentTerminal single_line_comment = new CommentTerminal("single_line_comment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal delimited_comment = new CommentTerminal("delimited_comment", "/*", "*/");
            NonGrammarTerminals.Add(single_line_comment);
            NonGrammarTerminals.Add(delimited_comment);
            #endregion

            #region Lexical structure

            StringLiteral StringLiteral = TerminalFactory.CreateCSharpString("StringLiteral");
            StringLiteral CharLiteral = TerminalFactory.CreateCSharpChar("CharLiteral");
            NumberLiteral Number = TerminalFactory.CreateCSharpNumber("Number");
            IdentifierTerminal identifier = TerminalFactory.CreateCSharpIdentifier("Identifier");

            CommentTerminal SingleLineComment = new CommentTerminal("SingleLineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal DelimitedComment = new CommentTerminal("DelimitedComment", "/*", "*/");
            NonGrammarTerminals.Add(SingleLineComment);
            NonGrammarTerminals.Add(DelimitedComment);

            //Symbols
            KeyTerm colon = ToTerm(":", "colon");
            KeyTerm semi = ToTerm(";", "semi");
            NonTerminal semi_opt = new NonTerminal("semi?");
            semi_opt.Rule = Empty | semi;
            KeyTerm dot = ToTerm(".", "dot");
            KeyTerm comma = ToTerm(",", "comma");
            NonTerminal comma_opt = new NonTerminal("comma_opt", Empty | comma);
            NonTerminal commas_opt = new NonTerminal("commas?");
            commas_opt.Rule = MakeStarRule(commas_opt, null, comma);
            KeyTerm qmark = ToTerm("?", "qmark");
            NonTerminal qmark_opt = new NonTerminal("qmark_opt", Empty | qmark);
            KeyTerm lbr = ToTerm("{");
            KeyTerm rbr = ToTerm("}");
            KeyTerm lpar = ToTerm("(");
            KeyTerm rpar = ToTerm(")");
            KeyTerm tgoto = ToTerm("goto");
            KeyTerm yld = ToTerm("yield");

            KeyTerm lparx = ToTerm("(*");
            #endregion

            #region NonTerminals
            //B.2.1. Basic concepts
            var qual_name_with_targs = new NonTerminal("qual_name_with_targs");
            var base_type_list = new NonTerminal("base_type_list");
            var generic_dimension_specifier = new NonTerminal("generic_dimension_specifier");
            var qual_name_segment = new NonTerminal("qual_name_segment");
            var qual_name_segments_opt = new NonTerminal("qual_name_segments?");
            var type_or_void = new NonTerminal("type_or_void", "type or void");
            var builtin_type = new NonTerminal("builtin_type", "built-in type");
            var type_ref_list = new NonTerminal("type_ref_list");
            var identifier_ext = new NonTerminal("identifier_ext");
            var identifier_or_builtin = new NonTerminal("identifier_or_builtin");

            //B.2.2. Types
            var type_ref = new NonTerminal("type_ref");
            var new_type_ref = new NonTerminal("new_type_ref");
            var type_argument_list = new NonTerminal("type_argument_list");
            var type_argument_list_opt = new NonTerminal("type_argument_list?");
            var integral_type = new NonTerminal("integral_type");

            //B.2.4. Expressions
            var argument = new NonTerminal("argument");
            var argument_list = new NonTerminal("argument_list");
            var argument_list_opt = new NonTerminal("argument_list?");
            var expression = new NonTerminal("expression", "expression");
            var expression_list = new NonTerminal("expression_list");
            var expression_opt = new NonTerminal("expression?");
            var conditional_expression = new NonTerminal("conditional_expression");
            var lambda_expression = new NonTerminal("lambda_expression");
            var query_expression = new NonTerminal("query_expression");
            var unary_operator = new NonTerminal("unary_operator");
            var assignment_operator = new NonTerminal("assignment_operator");
            var primary_expression = new NonTerminal("primary_expression");
            var pre_incr_decr_expression = new NonTerminal("pre_incr_decr_expression");
            var post_incr_decr_expression = new NonTerminal("post_incr_decr_expression");
            var primary_no_array_creation_expression = new NonTerminal("primary_no_array_creation_expression");
            var literal = new NonTerminal("literal");
            var parenthesized_expression = new NonTerminal("parenthesized_expression");
            var member_access = new NonTerminal("member_access");
            var member_access_segment = new NonTerminal("member_access_segment");
            var member_access_segments_opt = new NonTerminal("member_access_segments?");
            var array_indexer = new NonTerminal("array_indexer");
            var argument_list_par = new NonTerminal("argument_list_par");
            var argument_list_par_opt = new NonTerminal("argument_list_par?");
            var incr_or_decr = new NonTerminal("incr_or_decr");
            var incr_or_decr_opt = new NonTerminal("incr_or_decr?");
            var creation_args = new NonTerminal("creation_args");
            var object_creation_expression = new NonTerminal("object_creation_expression");
            // delegate creation is syntactically equiv to object creation
            //var delegate_creation_expression = new NonTerminal("delegate_creation_expression");
            var anonymous_object_creation_expression = new NonTerminal("anonymous_object_creation_expression");
            var typeof_expression = new NonTerminal("typeof_expression");
            var checked_expression = new NonTerminal("checked_expression");
            var unchecked_expression = new NonTerminal("unchecked_expression");
            var default_value_expression = new NonTerminal("default_value_expression");
            var anonymous_method_expression = new NonTerminal("anonymous_method_expression");

            var elem_initializer = new NonTerminal("elem_initializer");
            var elem_initializer_list = new NonTerminal("elem_initializer_list");
            var elem_initializer_list_ext = new NonTerminal("elem_initializer_list_ext");
            var initializer_value = new NonTerminal("initializer_value");

            var anonymous_object_initializer = new NonTerminal("anonymous_object_initializer");
            var member_declarator = new NonTerminal("member_declarator");
            var member_declarator_list = new NonTerminal("member_declarator_list");
            var unbound_type_name = new NonTerminal("unbound_type_name");
            var generic_dimension_specifier_opt = new NonTerminal("generic_dimension_specifier?");
            var anonymous_function_signature = new NonTerminal("anonymous_function_signature");
            var anonymous_function_signature_opt = new NonTerminal("anonymous_function_signature?");
            var anonymous_function_parameter = new NonTerminal("anonymous_function_parameter");
            var anonymous_function_parameter_decl = new NonTerminal("anonymous_function_parameter_decl");
            var anonymous_function_parameter_list_opt = new NonTerminal("anonymous_function_parameter_list?");
            var anonymous_function_parameter_modifier_opt = new NonTerminal("anonymous_function_parameter_modifier?");
            var anonymous_function_body = new NonTerminal("anonymous_function_body");
            var lambda_function_signature = new NonTerminal("lambda_function_signature");
            var bin_op_expression = new NonTerminal("bin_op_expression");
            var typecast_expression = new NonTerminal("typecast_expression");
            var bin_op = new NonTerminal("bin_op", "operator symbol");

            //B.2.5. Statements
            var statement = new NonTerminal("statement", "statement");
            var statement_list = new NonTerminal("statement_list");
            var statement_list_opt = new NonTerminal("statement_list?");
            var labeled_statement = new NonTerminal("labeled_statement");
            var declaration_statement = new NonTerminal("declaration_statement");
            var embedded_statement = new NonTerminal("embedded_statement");
            var embedded_statement_attributes_opt = new NonTerminal("embedded_statement_attributes?");
            var selection_statement = new NonTerminal("selection_statement");
            var iteration_statement = new NonTerminal("iteration_statement");
            var jump_statement = new NonTerminal("jump_statement");
            var try_statement = new NonTerminal("try_statement");
            var checked_statement = new NonTerminal("checked_statement");
            var unchecked_statement = new NonTerminal("unchecked_statement");
            var lock_statement = new NonTerminal("lock_statement");
            var using_statement = new NonTerminal("using_statement");
            var yield_statement = new NonTerminal("yield_statement");
            var block = new NonTerminal("block");
            var statement_expression = new NonTerminal("statement_expression");
            var statement_expression_list = new NonTerminal("statement_expression_list");
            var local_variable_declaration = new NonTerminal("local_variable_declaration");
            var local_constant_declaration = new NonTerminal("local_constant_declaration");
            var local_variable_type = new NonTerminal("local_variable_type");
            var local_variable_declarator = new NonTerminal("local_variable_declarator");
            var local_variable_declarators = new NonTerminal("local_variable_declarators");
            var if_statement = new NonTerminal("if_statement");
            var switch_statement = new NonTerminal("switch_statement");
            var else_clause_opt = new NonTerminal("else_clause?");
            var switch_section = new NonTerminal("switch_section");
            var switch_sections_opt = new NonTerminal("switch_sections?");
            var switch_label = new NonTerminal("switch_label");
            var switch_labels = new NonTerminal("switch_labels");
            var while_statement = new NonTerminal("while_statement");
            var do_statement = new NonTerminal("do_statement");
            var for_statement = new NonTerminal("for_statement");
            var foreach_statement = new NonTerminal("foreach_statement");
            var for_initializer_opt = new NonTerminal("for_initializer?");
            var for_condition_opt = new NonTerminal("for_condition?");
            var for_iterator_opt = new NonTerminal("for_iterator?");
            var break_statement = new NonTerminal("break_statement");
            var continue_statement = new NonTerminal("continue_statement");
            var goto_statement = new NonTerminal("goto_statement");
            var return_statement = new NonTerminal("return_statement");
            var throw_statement = new NonTerminal("throw_statement");
            var try_clause = new NonTerminal("try_clause");
            var try_clauses = new NonTerminal("try_clauses");

            var catch_clause = new NonTerminal("catch_clause");
            var finally_clause = new NonTerminal("finally_clause");
            var catch_specifier_opt = new NonTerminal("catch_specifier?");
            var identifier_opt = new NonTerminal("identifier?");

            var resource_acquisition = new NonTerminal("resource_acquisition");

            //namespaces, compilation units
            var compilation_unit = new NonTerminal("compilation_unit");
            var extern_alias_directive = new NonTerminal("extern_alias_directive");
            var extern_alias_directives_opt = new NonTerminal("extern_alias_directives?");
            var using_directive = new NonTerminal("using_directive");
            var using_directives = new NonTerminal("using_directives");
            var using_directives_opt = new NonTerminal("using_directives?");
            var namespace_declaration = new NonTerminal("namespace_declaration");
            var namespace_declarations_opt = new NonTerminal("namespace_declarations?");
            var qualified_identifier = new NonTerminal("qualified_identifier");
            var namespace_body = new NonTerminal("namespace_body");
            var namespace_member_declaration = new NonTerminal("namespace_member_declaration");
            var namespace_member_declarations = new NonTerminal("namespace_member_declarations");
            var using_alias_directive = new NonTerminal("using_alias_directive");
            var using_ns_directive = new NonTerminal("using_ns_directive");
            var type_declaration = new NonTerminal("type_declaration");
            var class_declaration = new NonTerminal("class_declaration");
            var delegate_declaration = new NonTerminal("delegate_declaration");
            var qualified_alias_member = new NonTerminal("qualified_alias_member");
            var class_body = new NonTerminal("class_body");

            //B.2.7 Classes
            //Terminal partial = ToTerm("partial");
            var type_parameter_list_opt = new NonTerminal("type_parameter_list?");
            var type_parameter = new NonTerminal("type_parameter");
            var type_parameters = new NonTerminal("type_parameters");
            var bases_opt = new NonTerminal("bases?");
            var type_parameter_constraints_clause = new NonTerminal("type_parameter_constraints_clause");
            var type_parameter_constraints_clauses_opt = new NonTerminal("type_parameter_constraints_clauses");
            var type_parameter_constraint = new NonTerminal("type_parameter_constraint");
            var type_parameter_constraints = new NonTerminal("type_parameter_constraints");
            var member_declaration = new NonTerminal("member_declaration");
            var member_declarations_opt = new NonTerminal("member_declarations?");
            var constant_declaration = new NonTerminal("constant_declaration");
            var field_declaration = new NonTerminal("field_declaration");
            var method_declaration = new NonTerminal("method_declaration");
            var property_declaration = new NonTerminal("property_declaration");
            var event_declaration = new NonTerminal("event_declaration");
            var indexer_declaration = new NonTerminal("indexer_declaration");
            var constructor_declaration = new NonTerminal("constructor_declaration");
            var destructor_declaration = new NonTerminal("destructor_declaration");
            var constant_declarator = new NonTerminal("constant_declarator");
            var constant_declarators = new NonTerminal("constant_declarators");
            var modifier = new NonTerminal("modifier");
            var modifiers_opt = new NonTerminal("modifiers?");
            var member_header = new NonTerminal("member_header");
            var accessor_name = new NonTerminal("accessor_name");
            var accessor_declaration = new NonTerminal("accessor_declaration");
            var accessor_declarations = new NonTerminal("accessor_declarations");
            var accessor_modifier_opt = new NonTerminal("accessor_modifier?");
            var event_body = new NonTerminal("event_body");
            var event_accessor_declarations = new NonTerminal("event_accessor_declarations");
            var add_accessor_declaration = new NonTerminal("add_accessor_declaration");
            var remove_accessor_declaration = new NonTerminal("remove_accessor_declaration");
            var indexer_name = new NonTerminal("indexer_name");
            var operator_declaration = new NonTerminal("operator_declaration");
            var conversion_operator_declaration = new NonTerminal("conversion_operator_declaration");
            var overloadable_operator = new NonTerminal("overloadable_operator");
            var operator_parameter = new NonTerminal("operator_parameter");
            var operator_parameters = new NonTerminal("operator_parameters");
            var conversion_operator_kind = new NonTerminal("conversion_operator_kind");
            var constructor_initializer_opt = new NonTerminal("constructor_initializer?");
            var constructor_base = new NonTerminal("constructor_base");
            var variable_declarator = new NonTerminal("variable_declarator");
            var variable_declarators = new NonTerminal("variable_declarators");
            var method_body = new NonTerminal("method_body");
            var formal_parameter_list = new NonTerminal("formal_parameter_list");
            var formal_parameter_list_par = new NonTerminal("formal_parameter_list_par");
            var fixed_parameter = new NonTerminal("fixed_parameter");
            var fixed_parameters = new NonTerminal("fixed_parameters");
            var parameter_modifier_opt = new NonTerminal("parameter_modifier?");
            var parameter_array = new NonTerminal("parameter_array");
            
            var rank_specifier = new NonTerminal("rank_specifier");
            var rank_specifiers = new NonTerminal("rank_specifiers");
            var rank_specifiers_opt = new NonTerminal("rank_specifiers?");
            var dim_specifier = new NonTerminal("dim_specifier");
            var dim_specifier_opt = new NonTerminal("dim_specifier?");
            var list_initializer = new NonTerminal("array_initializer");
            var list_initializer_opt = new NonTerminal("array_initializer?");

            var attribute_section = new NonTerminal("attribute_section");
            var attributes_opt = new NonTerminal("attributes?");
            var attribute_target_specifier_opt = new NonTerminal("attribute_target_specifier?");
            var attribute_target = new NonTerminal("attribute_target");
            var attribute = new NonTerminal("attribute");
            var attribute_list = new NonTerminal("attribute_list");
            var attribute_arguments_opt = new NonTerminal("attribute_arguments");
            var named_argument = new NonTerminal("named_argument");
            var attr_arg = new NonTerminal("attr_arg");
            var attribute_arguments_par_opt = new NonTerminal("attribute_arguments_par?");

            #endregion

            #region operators, punctuation and delimiters
            RegisterOperators(1, "||");
            RegisterOperators(2, "&&");
            RegisterOperators(3, "|");
            RegisterOperators(4, "^");
            RegisterOperators(5, "&");
            RegisterOperators(6, "==", "!=");
            RegisterOperators(7, "<", ">", "<=", ">=", "is", "as");
            RegisterOperators(8, "<<", ">>");
            RegisterOperators(9, "+", "-");
            RegisterOperators(10, "*", "/", "%");
            RegisterOperators(11, ".");
            //RestrictPrecedence(bin_op, unary_operator); 
            // RegisterOperators(12, "++", "--");
            #region comments
            //The following makes sense, if you think about "?" in context of operator precedence. 
            // What we say here is that "?" has the lowest priority among arithm operators.
            // Therefore, the parser should prefer reduce over shift when input symbol is "?".
            // For ex., when seeing ? in expression "a + b?...", the parser will perform Reduce:
            //  (a + b)->expr
            // and not shift the "?" symbol.  
            // Same goes for ?? symbol
            #endregion
            RegisterOperators(-3, "=", "+=", "-=", "*=", "/=", "%=", "&=", "|=", "^=", "<<=", ">>=");
            RegisterOperators(-2, "?");
            RegisterOperators(-1, "??");

            this.Delimiters = "{}[](),:;+-*/%&|^!~<>=";
            this.MarkPunctuation(";", ",", "(", ")", "{", "}", "[", "]", ":");
            this.MarkTransient(namespace_member_declaration, member_declaration, type_declaration, statement, embedded_statement, expression);
            //Whitespace and NewLine characters
            //TODO: 
            // 1. In addition to "normal" whitespace chars, the spec mentions "any char of unicode class Z" -
            //   need to create special comment-based terminal that simply eats these category-based whitechars and produces comment token. 
            // 2. Add support for multiple line terminators to LineComment
            this.LineTerminators = "\r\n\u2085\u2028\u2029"; //CR, linefeed, nextLine, LineSeparator, paragraphSeparator
            this.WhitespaceChars = " \t\r\n\v\u2085\u2028\u2029"; //add extra line terminators
            #endregion

            #region "<" conflict resolution
            var lt = new NonTerminal("_<_");
            lt.Rule = ResolveInCode() + "<";
            #endregion
            /*
      #region Keywords
      string strKeywords =
            "abstract as base bool break byte case catch char checked " +
            "class	const	continue decimal default delegate  do double else enum event explicit extern false finally " +
            "fixed float for foreach goto if implicit in int interface internal is lock long namespace " +
            "new null object operator out override params private protected public " +
            "readonly ref return sbyte sealed short sizeof stackalloc static string " +
            "struct switch this throw true try typeof uint ulong unchecked unsafe ushort using virtual void " +
            "volatile while";
      AddKeywordList(strKeywords);
      #endregion
 */

            // RULES
            //B.2.1. Basic concepts
            //qual_name_with_targs is an alias for namespace-name, namespace-or-type-name, type-name,

            generic_dimension_specifier.Rule = lt + commas_opt + ">";
            identifier_ext.Rule = identifier_or_builtin | "this" | "base";
            generic_dimension_specifier.Rule = lt + commas_opt + ">";

            builtin_type.Rule = integral_type | "bool" | "decimal" | "float" | "double" | "string" | "object" ;

            qual_name_segments_opt.Rule = MakeStarRule(qual_name_segments_opt, null, qual_name_segment);
            qual_name_segment.Rule = dot + identifier
                                    | "::" + identifier
                                    | type_argument_list;

            qual_name_with_targs.Rule = identifier_or_builtin + qual_name_segments_opt | xlang_type_choice ;
            identifier_or_builtin.Rule = identifier | builtin_type ;
            
            type_argument_list.Rule = lt + type_ref_list + ">";
            type_argument_list_opt.Rule = Empty | type_argument_list;

            //B.2.2. Types
            type_or_void.Rule = qual_name_with_targs | "void";

            type_ref.Rule = type_or_void + qmark_opt + rank_specifiers_opt + generic_dimension_specifier_opt;
            type_ref_list.Rule = MakePlusRule(type_ref_list, comma, type_ref);

            var comma_list_opt = new NonTerminal("comma_list?");
            comma_list_opt.Rule = MakeStarRule(comma_list_opt, comma);
            rank_specifier.Rule = "[" + comma_list_opt + "]";
            rank_specifiers.Rule = MakePlusRule(rank_specifiers, null, rank_specifier);
            rank_specifiers_opt.Rule = rank_specifiers.Q();
            integral_type.Rule = ToTerm("sbyte") | "byte" | "short" | "ushort" | "int" | "uint" | "long" | "ulong" | "char";

            //B.2.4. Variables
            //Quite strange in specs -
            //  variable-reference: 
            //     expression
            // Is that case it would be possible to do the following:    
            //                 GetMyStuff(out (a+b));  
            //  but MS c# rejects it   

            //B.2.4. Expressions
            argument.Rule = expression | "ref" + identifier | "out" + identifier;
            argument_list.Rule = MakePlusRule(argument_list, comma, argument);
            argument_list_opt.Rule = Empty | argument_list;
            expression.Rule = conditional_expression
                          | bin_op_expression
                          | typecast_expression
                          | primary_expression;
            expression_opt.Rule = Empty | expression;
            expression_list.Rule = MakePlusRule(expression_list, comma, expression);
            unary_operator.Rule = ToTerm("+") | "-" | "!" | "~" | "*";
            assignment_operator.Rule = ToTerm("=") | "+=" | "-=" | "*=" | "/=" | "%=" | "&=" | "|=" | "^=" | "<<=" | ">>=";
            conditional_expression.Rule = expression + PreferShiftHere() + qmark + expression + colon + expression;// + ReduceThis();
            bin_op_expression.Rule = expression + bin_op + expression;

            typecast_expression.Rule = parenthesized_expression + primary_expression;

            primary_expression.Rule =                                               literal |
                                                                                    unary_operator + primary_expression | 
                                                                                    parenthesized_expression | 
                                                                                    member_access| 
                                                                                    pre_incr_decr_expression | 
                                                                                    post_incr_decr_expression | 
                                                                                    object_creation_expression | 
                                                                                    anonymous_object_creation_expression | 
                                                                                    typeof_expression | 
                                                                                    checked_expression | 
                                                                                    unchecked_expression | 
                                                                                    default_value_expression | 
                                                                                    anonymous_method_expression | 
                                                                                    xlang_exists_expression_choice | 
                                                                                    xlang_intrinsic_expression | 
                                                                                    xlang_xpath_expression_choice;

            xlang_property_reference.Rule =                                         member_access;


            var xlang_property_reference_choice = new NonTerminal("xlang_property_reference_choice");
            var xlang_message_property_reference = new NonTerminal("xlang_message_property_reference");
            var xlang_message_part_property_reference = new NonTerminal("xlang_message_part_property_reference");
            var xlang_correlation_property_reference = new NonTerminal("xlang_correlation_property_reference");
            var xlang_service_link_property_reference = new NonTerminal("xlang_service_link_property_reference");
            var xlang_port_property_reference = new NonTerminal("xlang_port_property_reference");
            var xlang_service_property_reference = new NonTerminal("xlang_service_property_reference");

            xlang_message_reference.Rule =                                          xlang_message_identifier;
            xlang_message_part_reference.Rule =                                     xlang_message_reference + dot + xlang_messagepart_identifier;
            xlang_message_or_message_part_reference_choice.Rule =                   xlang_message_part_reference |
                                                                                    xlang_message_reference;

            xlang_exists_expression_short.Rule =                                    xlang_property_reference + "exists";   
            xlang_exists_expression_message_reference.Rule =                        xlang_property_reference + "exists" + xlang_message_reference;
            xlang_exists_expression_message_part_reference.Rule =                   xlang_property_reference + "exists" + xlang_message_part_reference;
            xlang_exists_expression_choice.Rule =                                   xlang_exists_expression_short |
                                                                                    xlang_exists_expression_message_part_reference |
                                                                                    xlang_exists_expression_message_reference;

            xlang_xpath_expression_short.Rule =                                     "xpath" + lpar + literal + rpar;
            xlang_xpath_expression_long.Rule =                                      "xpath" + lpar + xlang_message_or_message_part_reference_choice + comma + literal + rpar;
            xlang_xpath_expression_choice.Rule =                                    xlang_xpath_expression_short | 
                                                                                    xlang_xpath_expression_long;

            xlang_intrinsic_expression.Rule =                                       "succeeded" + lpar + xlang_transaction_identifier + rpar;

            dim_specifier.Rule = "[" + expression_list + "]";
            dim_specifier_opt.Rule = dim_specifier.Q();
            literal.Rule = Number | StringLiteral | CharLiteral | "true" | "false" | "null";
            parenthesized_expression.Rule = lpar + expression + rpar;
            pre_incr_decr_expression.Rule = incr_or_decr + member_access;
            post_incr_decr_expression.Rule = member_access + incr_or_decr;

            //joined invocation_expr and member_access; for member access left the most general variant
            member_access.Rule = identifier_ext + member_access_segments_opt;
            member_access_segments_opt.Rule = MakeStarRule(member_access_segments_opt, null, member_access_segment);
            member_access_segment.Rule = dot + identifier
                                        | array_indexer 
                                        | argument_list_par
                                        | type_argument_list;
            array_indexer.Rule = "[" + expression_list + "]";

            argument_list_par.Rule = lpar + argument_list_opt + rpar;

            argument_list_par_opt.Rule = Empty | argument_list_par;

            list_initializer.Rule = lbr + elem_initializer_list_ext + rbr;
            list_initializer_opt.Rule = list_initializer.Q();

            elem_initializer.Rule = initializer_value | identifier + "=" + initializer_value;
            elem_initializer_list.Rule = MakePlusRule(elem_initializer_list, comma, elem_initializer);
            elem_initializer_list_ext.Rule = Empty | elem_initializer_list + comma_opt;
            initializer_value.Rule = expression | list_initializer;

            //delegate, anon-object, object
            object_creation_expression.Rule = "new" + qual_name_with_targs + qmark_opt + creation_args + list_initializer_opt;
            creation_args.Rule = dim_specifier | rank_specifier | argument_list_par;

            anonymous_object_creation_expression.Rule = "new" + anonymous_object_initializer;
            anonymous_object_initializer.Rule = lbr + rbr | lbr + member_declarator_list + comma_opt + rbr;
            member_declarator.Rule = expression | identifier + "=" + expression;
            member_declarator_list.Rule = MakePlusRule(member_declarator_list, comma, member_declarator);
            //typeof
            typeof_expression.Rule = "typeof" + lpar + type_ref + rpar;
            generic_dimension_specifier_opt.Rule = Empty | lt + commas_opt + ">";
            //checked, unchecked
            checked_expression.Rule = "checked" + parenthesized_expression;
            unchecked_expression.Rule = "unchecked" + parenthesized_expression;
            //default-value
            default_value_expression.Rule = "default" + lpar + type_ref + rpar;
            //note: we treat ?? as bin-operation, so null-coalesce-expr used in spec as first (condition) component is replaced with expression
            // we resolve all this expr hierarchies of binary expressions using precedence

            //anonymous method and lambda - we join explicit and implicit param definitions, making 'type' element optional
            // TODO: add after-parse check for this
            anonymous_method_expression.Rule = "delegate" + anonymous_function_signature_opt + block;
            lambda_expression.Rule = lambda_function_signature + "=>" + anonymous_function_body;
            lambda_function_signature.Rule = anonymous_function_signature | identifier;
            anonymous_function_signature.Rule = lpar + anonymous_function_parameter_list_opt + rpar;
            anonymous_function_signature_opt.Rule = anonymous_function_signature.Q();
            anonymous_function_parameter_modifier_opt.Rule = Empty | "ref" | "out";
            anonymous_function_parameter.Rule = anonymous_function_parameter_modifier_opt + anonymous_function_parameter_decl;
            anonymous_function_parameter_decl.Rule = identifier | type_ref + identifier;
            anonymous_function_parameter_list_opt.Rule = MakeStarRule(anonymous_function_parameter_list_opt, comma, anonymous_function_parameter_decl);
            anonymous_function_body.Rule = expression | block;

            //we don't use grammar expressions to specify operator precedence, so we combine all these grammar elements together
            // and define just bin_op_expression. Where to put it? 
            // In spec:     non_assignment_expression.Rule = conditional_expression | lambda_expression | query_expression;
            //I think it's a mistake; there must be additional entry here for arithm expressions, so we put them here. 
            // We also have to add "is" and "as" expressions here, as we don't build entire hierarchy of elements for expressing
            // precedence (where they appear in original spec); so we put them here 
            bin_op.Rule = lt
                        | "||" | "&&" | "|" | "^" | "&" | "==" | "!=" | ">" | "<=" | ">=" | "<<" | ">>" | "+" | "-" | "*" | "/" | "%"
                        | "=" | "+=" | "-=" | "*=" | "/=" | "%=" | "&=" | "|=" | "^=" | "<<=" | ">>="
                        | "is" | "as" | "??" ;

            //type_check_expression.Rule = expression + "is" + type_ref | expression + "as" + type_ref;

            //Queries
            query_expression.Rule = "from";

            //B.2.5. Statements
            statement.Rule = labeled_statement | declaration_statement | embedded_statement;
            statement.ErrorRule = SyntaxError + semi; //skip all until semicolon

            var statement_attributes_opt = new NonTerminal("statement_attributes?");
            statement_attributes_opt.Rule = attributes_opt + statement;

            statement_list.Rule = MakePlusRule(statement_list, null, statement_attributes_opt);
            statement_list_opt.Rule = Empty | statement_list;
            //labeled_statement
            labeled_statement.Rule = identifier + colon + embedded_statement;
            //declaration_statement
            declaration_statement.Rule = local_variable_declaration + semi | local_constant_declaration + semi;
            local_variable_declaration.Rule = local_variable_type + local_variable_declarators; //!!!
            local_variable_type.Rule = "var" | member_access | xlang_type_choice; //to fix the conflict, changing to member-access here
            local_variable_declarator.Rule = identifier | identifier + "=" + initializer_value;
            local_variable_declarators.Rule = MakePlusRule(local_variable_declarators, comma, local_variable_declarator);
            local_constant_declaration.Rule = "const" + type_ref + constant_declarators;
            //embedded_statement
            embedded_statement.Rule = block | semi /*empty_statement*/ | statement_expression + semi | selection_statement
                                     | iteration_statement | jump_statement | try_statement | checked_statement | unchecked_statement
                                     | lock_statement | using_statement | yield_statement
                                     | xlang_statement_choice;

            embedded_statement_attributes_opt.Rule = attributes_opt + embedded_statement;

            block.Rule = lbr + statement_list_opt + rbr;
            //selection (if and switch)
            selection_statement.Rule = if_statement | switch_statement;
            if_statement.Rule = ToTerm("if") + lpar + expression + rpar + embedded_statement_attributes_opt + else_clause_opt;
            else_clause_opt.Rule = Empty | PreferShiftHere() + "else" + embedded_statement_attributes_opt;
            switch_statement.Rule = "switch" + parenthesized_expression + lbr + switch_sections_opt + rbr;
            switch_section.Rule = switch_labels + statement_list;
            switch_sections_opt.Rule = MakeStarRule(switch_sections_opt, null, switch_section);
            switch_label.Rule = "case" + expression + colon | "default" + colon;
            switch_labels.Rule = MakePlusRule(switch_labels, null, switch_label);
            //iteration statements
            iteration_statement.Rule = while_statement | do_statement | for_statement | foreach_statement;
            while_statement.Rule = "while" + parenthesized_expression + embedded_statement_attributes_opt;
            do_statement.Rule = "do" + embedded_statement_attributes_opt + "while" + parenthesized_expression + semi;
            for_statement.Rule = "for" + lpar + for_initializer_opt + semi + for_condition_opt + semi + for_iterator_opt + rpar + embedded_statement_attributes_opt;
            for_initializer_opt.Rule = Empty | local_variable_declaration | statement_expression_list;
            for_condition_opt.Rule = Empty | expression;
            for_iterator_opt.Rule = Empty | statement_expression_list;
            foreach_statement.Rule = "foreach" + lpar + local_variable_type + identifier + "in" + expression + rpar + embedded_statement_attributes_opt;
            //jump-statement
            jump_statement.Rule = break_statement | continue_statement | goto_statement | return_statement | throw_statement;
            break_statement.Rule = "break" + semi;
            continue_statement.Rule = "continue" + semi;
            goto_statement.Rule = tgoto + identifier + semi | tgoto + "case" + expression + semi | tgoto + "default" + semi;
            return_statement.Rule = "return" + expression_opt + semi;
            throw_statement.Rule = "throw" + expression_opt + semi;
            //try-statement
            //changed to avoid conflicts; need to check correct ordering of catch/finally clause in after-parse validation
            try_statement.Rule = "try" + block + try_clauses;
            try_clause.Rule = catch_clause | finally_clause;
            try_clauses.Rule = MakePlusRule(try_clauses, null, try_clause);
            catch_clause.Rule = "catch" + catch_specifier_opt + block;
            finally_clause.Rule = "finally" + block;
            catch_specifier_opt.Rule = Empty | lpar + qual_name_with_targs + identifier_opt + rpar;
            identifier_opt.Rule = Empty | identifier;
            //checked, unchecked, locked, using
            checked_statement.Rule = "checked" + block;
            unchecked_statement.Rule = "unchecked" + block;
            lock_statement.Rule = "lock" + parenthesized_expression + embedded_statement_attributes_opt;
            using_statement.Rule = "using" + lpar + resource_acquisition + rpar + embedded_statement_attributes_opt;
            resource_acquisition.Rule = local_variable_declaration | expression;
            //yield statement
            yield_statement.Rule = yld + "return" + expression + semi | yld + "break" + semi;

            //expression statement
            // expression_statement.Rule = statement_expression + semi;
            statement_expression.Rule = object_creation_expression
                                      | member_access | member_access + assignment_operator + expression
                                      | pre_incr_decr_expression | post_incr_decr_expression
                                      ;

            statement_expression_list.Rule = MakePlusRule(statement_expression_list, comma, statement_expression);
            incr_or_decr_opt.Rule = Empty | ToTerm("++") | "--";
            incr_or_decr.Rule = ToTerm("++") | "--";

            type_parameter.Rule = attributes_opt + identifier;
            type_parameters.Rule = MakePlusRule(type_parameters, comma, type_parameter);
            type_parameter_list_opt.Rule = Empty | lt + type_parameters + ">";
            type_parameter_constraints_clause.Rule = "where" + type_parameter + colon + type_parameter_constraints;
            type_parameter_constraints.Rule = MakePlusRule(type_parameter_constraints, comma, type_parameter_constraint);
            type_parameter_constraints_clauses_opt.Rule = MakeStarRule(type_parameter_constraints_clauses_opt, null, type_parameter_constraints_clause);
            //Note for post-processing - make sure the order is correct: new() is always last, etc. See p.503 of the spec 
            type_parameter_constraint.Rule = qual_name_with_targs | "class" | "struct" | ToTerm("new") + lpar + rpar;

            ////Class members
            ////Note: we split operator-declaration into two separate operator elements: bin/unary and conversion operators
            ////  to avoid possible ambiguities and conflicts
            member_declaration.Rule = constant_declaration | field_declaration | method_declaration
               | property_declaration | event_declaration | indexer_declaration
               | operator_declaration | conversion_operator_declaration
               | constructor_declaration | destructor_declaration | type_declaration;
            member_declaration.ErrorRule = SyntaxError + ";" | SyntaxError + "}";
            member_declarations_opt.Rule = MakeStarRule(member_declarations_opt, null, member_declaration);

            ////Modifiers - see note #1 in Notes.txt file
            modifier.Rule = ToTerm("new") | "public" | "protected" | "internal" | "private" | "static" | "virtual" | "sealed" |
              "override" | "abstract" | "readonly" | "volatile" | "partial" | "extern"; //!!!
            modifiers_opt.Rule = MakeStarRule(modifiers_opt, null, modifier);
            //Joined member header - see note #2
            member_header.Rule = attributes_opt + modifiers_opt;
            constant_declaration.Rule = member_header + "const" + type_ref + constant_declarators + semi;
            constant_declarator.Rule = identifier + "=" + expression;
            constant_declarators.Rule = MakePlusRule(constant_declarators, comma, constant_declarator);
            field_declaration.Rule = member_header + type_ref + variable_declarators + semi;
            variable_declarator.Rule = identifier | identifier + "=" + elem_initializer;
            variable_declarators.Rule = MakePlusRule(variable_declarators, comma, variable_declarator);
            //See note #3 about merging type_parameter_list into type_arguments of the preceding qual_name. 
            method_declaration.Rule = member_header + type_ref + qual_name_with_targs  // + type_parameter_list.Q() 
              + formal_parameter_list_par + type_parameter_constraints_clauses_opt + method_body;
            formal_parameter_list.Rule = fixed_parameters | fixed_parameters + comma + parameter_array | parameter_array;
            formal_parameter_list_par.Rule = lpar + rpar | lpar + formal_parameter_list + rpar;

            fixed_parameter.Rule = attributes_opt + parameter_modifier_opt + type_ref + identifier;
            fixed_parameters.Rule = MakePlusRule(fixed_parameters, comma, fixed_parameter);
            parameter_modifier_opt.Rule = Empty | "ref" | "out" | "this";
            parameter_array.Rule = attributes_opt + "params" + type_ref + /*"[" + "]" + */ identifier;
            method_body.Rule = block | semi;
            // See note #4 about member-name
            //TODO: add after-parse validation that no more than one accessor of each type is there.
            property_declaration.Rule = member_header + type_ref + qual_name_with_targs/*member-name*/ + lbr + accessor_declarations + rbr;
            accessor_declaration.Rule = attributes_opt + accessor_modifier_opt + accessor_name + block;
            accessor_declarations.Rule = MakePlusRule(accessor_declarations, null, accessor_declaration);
            accessor_name.Rule = ToTerm("get") | "set";
            accessor_modifier_opt.Rule = Empty | "protected" | "internal" | "private" |
                                 ToTerm("protected") + "internal" | ToTerm("internal") + "protected";

            attributes_opt.Rule = MakeStarRule(attributes_opt, null, attribute_section);
            attribute_section.Rule = "[" + attribute_target_specifier_opt + attribute_list + comma_opt + "]";
            attribute_list.Rule = MakePlusRule(attribute_list, comma, attribute);
            attribute.Rule = qual_name_with_targs + attribute_arguments_par_opt;

            attribute_target_specifier_opt.Rule = Empty | attribute_target + colon;
            attribute_target.Rule = ToTerm("field") | "event" | "method" | "param" | "property" | "return" | "type";
            attribute_arguments_par_opt.Rule = Empty | lpar + attribute_arguments_opt + rpar;
            attribute_arguments_opt.Rule = MakeStarRule(attribute_arguments_opt, comma, attr_arg);
            attr_arg.Rule = identifier + "=" + expression | expression;

            #endregion

            //Prepare term set for conflict resolution
            _skipTokensInPreview.UnionWith(new Terminal[] { dot, identifier, comma, ToTerm("::"), comma, ToTerm("["), ToTerm("]") });

            xlang_operators.Rule =                      ToTerm("exists"); RegisterOperators(7, "exists");

            //attributes_opt clashes with the array indexer of member access
            //http://technet.microsoft.com/en-us/library/aa560334(BTS.70).aspx
            //support for array indexers removed from member access

            this.Root =                                 xlang_orchestration;

            xlang_orchestration.Rule =                  xlang_module_att_opt;

            xlang_module.Rule =                         "module" + xlang_module_identifier + 
                                                        lbr + 
                                                        xlang_type_definitions + 
                                                        rbr;

            xlang_accesmodifier_choice.Rule =           "public" | ToTerm("private") | "internal";

            xlang_type_definition.Rule =                xlang_accesmodifier_choice + xlang_type_definition_choice;

            xlang_type_definition_choice.Rule =         xlang_messagetype_definition |
                                                        xlang_porttype_definition |
                                                        xlang_correlationtype_definition |
                                                        xlang_servicelinktype_definition |
                                                        xlang_servicetype_definition;

            xlang_messagetype_definition.Rule =        "messagetype" + xlang_messagetype_identifier + 
                                                        lbr + 
                                                        xlang_message_parts + 
                                                        rbr + 
                                                        semi;

            xlang_messagepart_choice.Rule =             xlang_body_part | 
                                                        xlang_nonbody_part;

            xlang_body_part.Rule =                      "body" + type_ref + identifier + semi;

            xlang_nonbody_part.Rule =                   type_ref + identifier + semi;

            xlang_porttype_definition.Rule =           "porttype" + xlang_porttype_identifier + 
                                                        lbr + 
                                                        xlang_porttype_operations + 
                                                        rbr + 
                                                        semi;

            xlang_mep_choice.Rule =                     "oneway" | 
                                                        ToTerm("requestresponse") | 
                                                        "solicitresponse";

            xlang_porttype_operation.Rule =            xlang_mep_choice + xlang_operation_identifier + 
                                                        lbr + 
                                                        xlang_operation_messagetypes + 
                                                        rbr + 
                                                        semi;

            xlang_operation_messagetype.Rule =         type_ref;

            xlang_operation_fault_messagetype.Rule =   identifier + "=" + type_ref;

            xlang_operation_messagetype_choice.Rule =  xlang_operation_messagetype | 
                                                        xlang_operation_fault_messagetype;

            xlang_correlationtype_definition.Rule =    "correlationtype" + xlang_correlationtype_identifier + 
                                                        lbr + 
                                                        xlang_correlation_properties + 
                                                        rbr + 
                                                        semi;

            xlang_servicelinktype_definition.Rule =    "servicelinktype" + xlang_servicelinktype_identifier + 
                                                        lbr + 
                                                        xlang_roletypes +
                                                        rbr + 
                                                        semi;

            xlang_roletype.Rule =                      xlang_roletype_identifier +
                                                        lbr +
                                                        xlang_porttype_identifier + 
                                                        rbr + 
                                                        semi;

            xlang_longrunning_transaction.Rule =        "longrunning" + ToTerm("transaction");
            
            xlang_atomic_transaction.Rule =             "atomic" + ToTerm("transaction");

            xlang_transaction_type_choice.Rule =        xlang_longrunning_transaction  |
                                                        xlang_atomic_transaction  ;

            xlang_transaction_declaration.Rule =        xlang_transaction_type_opt + xlang_transaction_identifier;

            xlang_servicetype_definition.Rule =    "service" + xlang_transaction_declaration +
                                                    lbr +
                                                    xlang_scope_implementation +
                                                    rbr;

            xlang_scope.Rule =                      "scope" + xlang_transaction_declaration_opt +
                                                    lbr + 
                                                    xlang_scope_implementation + 
                                                    rbr;

            xlang_scope_statement_choice.Rule =     declaration_statement |
                                                    xlang_body |
                                                    xlang_exceptions |
                                                    xlang_compensation;

            xlang_scope_implementation.Rule =       xlang_scope_statements;

            xlang_port_direction.Rule =             "uses" | 
                                                    ToTerm("implements");

            //composite types

            xlang_servicelinktype.Rule =           "servicelink" + xlang_port_direction + identifier_or_builtin + qual_name_segments_opt;

            xlang_porttype.Rule =                  "port" + xlang_port_direction + identifier_or_builtin + qual_name_segments_opt;
            
            xlang_correlationtype.Rule =           "correlation" + identifier_or_builtin + qual_name_segments_opt;
            
            xlang_messagetype.Rule =               "message" + identifier_or_builtin + qual_name_segments_opt;

            xlang_type_choice.Rule =                xlang_servicelinktype |
                                                    xlang_porttype |
                                                    xlang_correlationtype |
                                                    xlang_messagetype;

            xlang_body.Rule =                       "body" + xlang_formal_parameters_par_opt + 
                                                    lbr + 
                                                    statement_list_opt + 
                                                    rbr;

            xlang_exceptions.Rule =                 "exceptions" + 
                                                    lbr + 
                                                    xlang_catch_clauses + 
                                                    rbr;

            xlang_compensation.Rule =               "compensation" + lpar + rpar +
                                                    lbr +
                                                    statement_list_opt +
                                                    rbr;

            xlang_parallel.Rule =                   "parallel" + xlang_formal_parameters_par_opt + 
                                                    lbr + 
                                                    xlang_tasks + 
                                                    rbr;

            xlang_task.Rule =                       "task" + xlang_formal_parameters_par_opt + 
                                                    lbr + 
                                                    statement_list_opt + 
                                                    rbr;

            xlang_construct.Rule =                  "construct" + xlang_message_identifiers +
                                                    lbr +
                                                    xlang_construct_statements +
                                                    rbr;

            xlang_listen.Rule =                     "listen" +                  
                                                    lbr + 
                                                    xlang_listen_branches + 
                                                    rbr;

            xlang_timeout_branch.Rule =             "timeout" + xlang_timespan_returning_expression + 
                                                    lbr + 
                                                    statement_list + 
                                                    rbr;

            xlang_receive_branch.Rule =             "until" + xlang_receive + 
                                                    lbr + 
                                                    statement_list + 
                                                    rbr;

            xlang_listen_choice.Rule =              xlang_timeout_branch | 
                                                    xlang_receive_branch;

            xlang_statement_choice.Rule =           xlang_scope |
                                                    xlang_parallel |
                                                    xlang_construct |
                                                    xlang_listen |
                                                    xlang_send_statement |
                                                    xlang_receive_statement |
                                                    xlang_call_statement |
                                                    xlang_exec_statement |
                                                    xlang_suspend_statement |
                                                    xlang_terminate_statement |
                                                    xlang_delay_statement;

            xlang_construct_choice.Rule =           semi |
                                                    statement_expression + semi | 
                                                    xlang_transform_statement | 
                                                    selection_statement;

            xlang_follow_correlation.Rule =         member_access;

            xlang_initialize_correlation.Rule =     "initialize" + member_access;

            xlang_correlation_arg_choice.Rule =     xlang_initialize_correlation |
                                                    xlang_follow_correlation;

            xlang_correlation_args.Rule =           MakeStarRule(xlang_correlation_args, comma, xlang_correlation_arg_choice);
            xlang_correlation_args_opt.Rule =       Empty | comma + xlang_correlation_args;
            xlang_send_arguments.Rule =             lpar + member_access + comma + member_access + xlang_correlation_args_opt + rpar;
            xlang_receive_arguments.Rule =          lpar + member_access + comma + member_access + xlang_correlation_args_opt + rpar;

            xlang_call_statement.Rule =             "call" + member_access + identifier + semi;
            xlang_exec_statement.Rule =             "exec" + member_access + semi;
            xlang_receive.Rule =                    xlang_activate_opt + "receive" + xlang_receive_arguments;
            xlang_receive_statement.Rule =          xlang_receive + semi;
            xlang_send_statement.Rule               = "send" + xlang_send_arguments + semi;
            xlang_suspend_statement.Rule =          "suspend" + member_access + semi | "suspend" + StringLiteral + semi;
            xlang_terminate_statement.Rule =        "terminate" + member_access + semi;
            xlang_transform_statement.Rule =        "transform" + lpar + identifier + rpar + "=" + member_access + semi;
            xlang_delay.Rule =                      "delay" + xlang_timespan_returning_expression;
            xlang_delay_statement.Rule =            xlang_delay + semi;

            xlang_module_identifier.Rule =          MakePlusRule(xlang_module_identifier, dot, identifier);
            xlang_servicetype_definitions.Rule =    MakePlusRule(xlang_servicetype_definitions, null, xlang_servicetype_definition);
            xlang_statement_list.Rule =             MakeStarRule(xlang_statement_list, null, xlang_statement_att_opt);
            xlang_type_definitions.Rule =           MakeStarRule(xlang_type_definitions, null, xlang_type_definition_att_opt);
            xlang_messagetypes.Rule =               MakeStarRule(xlang_messagetypes, null, xlang_messagetype_definition);
            xlang_message_parts.Rule =              MakePlusRule(xlang_message_parts, null, xlang_messagepart_choice);
            xlang_porttype_definitions.Rule =       MakeStarRule(xlang_porttype_definitions, null, xlang_porttype_definition);
            xlang_porttype_operations.Rule =        MakePlusRule(xlang_porttype_operations, null, xlang_porttype_operation);
            xlang_operation_messagetypes.Rule =     MakeStarRule(xlang_operation_messagetypes, ToTerm(","), xlang_operation_messagetype_choice);
            xlang_correlation_properties.Rule =     MakeStarRule(xlang_correlation_properties, comma, type_ref);
            xlang_correlationtypes.Rule =           MakeStarRule(xlang_correlationtypes, null, xlang_correlationtype_definition);
            xlang_servicelinktypes.Rule =           MakeStarRule(xlang_servicelinktypes, null, xlang_servicelinktype_definition);
            xlang_scope_statements.Rule =           MakeStarRule(xlang_scope_statements, null, xlang_scope_statement_att_opt);
            xlang_listen_branches.Rule =            MakePlusRule(xlang_listen_branches, null, xlang_listen_branch_att_opt);
            xlang_catch_clauses.Rule =              MakePlusRule(xlang_catch_clauses, null, xlang_catch_clause_att_opt);
            xlang_tasks.Rule =                      MakePlusRule(xlang_tasks, null, xlang_task);
            xlang_message_identifiers.Rule =        MakePlusRule(xlang_message_identifiers, comma, identifier);
            xlang_construct_statements.Rule =       MakePlusRule(xlang_construct_statements, null, xlang_construct_choice_att_opt);
            xlang_roletypes.Rule =                  MakePlusRule(xlang_roletypes, null, xlang_roletype);

            xlang_module_att_opt.Rule =             attributes_opt + xlang_module;
            xlang_catch_clause_att_opt.Rule =       attributes_opt + catch_clause;
            xlang_construct_choice_att_opt.Rule =   attributes_opt + xlang_construct_choice;
            xlang_listen_branch_att_opt.Rule =      attributes_opt + xlang_listen_choice;
            xlang_type_definition_att_opt.Rule =    attributes_opt + xlang_type_definition;
            xlang_scope_statement_att_opt.Rule =    attributes_opt + xlang_scope_statement_choice;
            xlang_statement_att_opt.Rule =          attributes_opt + xlang_statement_choice;

            xlang_transaction_declaration_opt.Rule = Empty | xlang_transaction_declaration;
            xlang_transaction_type_opt.Rule =       Empty | xlang_transaction_type_choice;
            xlang_scope_statements_opt.Rule =       Empty | xlang_scope_statements;
            xlang_compensation_opt.Rule =           Empty | xlang_compensation;
            xlang_exceptions_opt.Rule =             Empty | xlang_exceptions;
            xlang_formal_parameters_par_opt.Rule =  Empty | formal_parameter_list_par;
            xlang_activate_opt.Rule =               Empty | "activate";

            xlang_limited_object_creation_expression.Rule = "new" + qual_name_with_targs + qmark_opt + creation_args; //removed array inits
            xlang_timespan_returning_expression.Rule = xlang_limited_object_creation_expression | member_access;

            this.MarkTransient(xlang_statement_att_opt);

            this.MarkTransient(xlang_transaction_declaration_opt);
            this.MarkTransient(xlang_transaction_type_opt);
            this.MarkTransient(xlang_scope_statements_opt);
            this.MarkTransient(xlang_compensation_opt);
            this.MarkTransient(xlang_exceptions_opt);
            this.MarkTransient(xlang_formal_parameters_par_opt);

            this.MarkTransient(xlang_accesmodifier_choice);
            this.MarkTransient(xlang_mep_choice);
            this.MarkTransient(xlang_port_direction);
            this.MarkTransient(xlang_messagepart_choice);
            this.MarkTransient(xlang_construct_choice);
            this.MarkTransient(xlang_statement_choice);
            this.MarkTransient(xlang_type_definition_choice);
            this.MarkTransient(xlang_operation_messagetype_choice);
            this.MarkTransient(xlang_type_choice);
            this.MarkTransient(xlang_listen_choice);
            this.MarkTransient(xlang_transaction_type_choice);

        }

        //Here is an elaborate generic declaration which can be used as a good test. Perfectly legal, uncomment it to check that c#
        // accepts it:
        // List<Dictionary<string, object[,]>> genericVar; 
        public override void OnResolvingConflict(ConflictResolutionArgs args)
        {
            switch (args.Context.CurrentParserInput.Term.Name)
            {
                case "<":
                    args.Scanner.BeginPreview();
                    int ltCount = 0;
                    string previewSym;
                    while (true)
                    {
                        //Find first token ahead (using preview mode) that is either end of generic parameter (">") or something else
                        Token preview;
                        do
                        {
                            preview = args.Scanner.GetToken();
                        } while (_skipTokensInPreview.Contains(preview.Terminal) && preview.Terminal != base.Eof);
                        //See what did we find
                        previewSym = preview.Terminal.Name;
                        if (previewSym == "<")
                            ltCount++;
                        else if (previewSym == ">" && ltCount > 0)
                        {
                            ltCount--;
                            continue;
                        }
                        else
                            break;
                    }
                    //if we see ">", then it is type argument, not operator
                    if (previewSym == ">")
                        args.Result = ParserActionType.Shift;
                    else
                        args.Result = ParserActionType.Reduce;
                    args.Scanner.EndPreview(true); //keep previewed tokens; important to keep ">>" matched to two ">" symbols, not one combined symbol (see method below)
                    return;
            }
        }

        //In preview, we may run into combination '>>' which is a comletion of nested generic parameters.
        // It should be recognized as two ">" symbols, not a single ">>" operator
        // By default, the ">>" has higher priority over single ">" symbol because it is longer. 
        // When this method is called we force the selection to a single ">"
        public override void OnScannerSelectTerminal(ParsingContext context)
        {
            if (context.Source.PreviewChar == '>' && context.Status == ParserStatus.Previewing)
            {
                context.CurrentTerminals.Clear();
                context.CurrentTerminals.Add(ToTerm(">")); //select the ">" terminal
            }
            base.OnScannerSelectTerminal(context);
        }

    }
}
