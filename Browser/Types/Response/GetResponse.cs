﻿using System;

namespace CloudBrowserClient.Browser.Types.Response;

public class GetResponse {
    public ResponseStatus Error { get; set; }
    public Session[] Sessions { get; set; }
}

public class Session {
    public DateTime StartedOn { get; set; }
    public string Label { get; set; }
    public string Address { get; set; }
    public string VNCPass { get; set; }
}