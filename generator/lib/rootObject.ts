export interface Flag {
  name: string;
  kind: string;
  char: string;
  description: string;
  longDescription: string;
  required: boolean | undefined;
  type: string;
  unit: string;
  values: string[];
}

export interface Result {
  command: string;
  id: string;
  summary: string;
  description: string;
  flags: { [key: string]: Flag };
  flagsConfig: { [key: string]: Flag };
  supportsUsername: boolean;
  supportsDevhubUsername: boolean;
  usage: string;
  examples: object;
}

export interface CommandExamples {
  command: string;
  description: string;
}