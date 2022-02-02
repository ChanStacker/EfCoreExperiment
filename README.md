# EfCoreExperiment
EfCore and migration trial from a console and Asp.Net core app

When using EF in a console application and attempting to use the dotnet migration tool, it does not work unless there is a class that implements IDesignTimeDbContextFactory<T> where T is the context class derived from DbContext
