SET CLASSPATH=.;antlr-4.7.1-complete.jar;%CLASSPATH%

doskey antlr4=java org.antlr.v4.Tool $*

antlr4 -Dlanguage=CSharp -visitor -package D7.ModeledKnowledge.Infrastructure.Expression Expression.g4