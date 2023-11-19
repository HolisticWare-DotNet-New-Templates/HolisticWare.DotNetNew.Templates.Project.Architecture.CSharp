# from
# 
//---------------------------------------------------------------------------------------
string 
                                        GetAgentName
                                        (                                            
                                        ) 
                                        =>
    EnvironmentVariable("AGENT_NAME", "");

bool 
                                        IsCIBuild
                                        (                                            
                                        ) 
                                        =>
    !String.IsNullOrWhiteSpace(GetAgentName());

bool 
                                        IsHostedAgent
                                        (                                            
                                        ) 
                                        =>
    GetAgentName().StartsWith("Azure Pipelines") 
    || 
    GetAgentName().StartsWith("Hosted Agent")
    ;
//---------------------------------------------------------------------------------------
