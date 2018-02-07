#!/bin/bash
# Arguments:
#  $1: NR APP ID
#  $2: NR API key
#  $3: SCM revision
#  $4: Build Number
#  $5: User name (build queued by)

echo "NR APP ID   : $1"
echo "NR API key  : $2"
echo "SCM revision: $3"
echo "Build Number: $4"
echo "User name   : $5"

curl -X POST 'https://api.newrelic.com/v2/applications/'$1'/deployments.json' \
     -H 'X-Api-Key:'$2 -i \
     -H 'Content-Type: application/json' \
     -d \
'{
  "deployment": {
    "revision": "'$3'",
    "description": "'$4'",
    "user": "'$5'"
  }
}' 
