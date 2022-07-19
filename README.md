[![Github All Releases](https://img.shields.io/github/downloads/Killers0992/VrcOscIntegrations/total.svg)]()
# VRC OSC Integrations
Application which contains OSC integrations for vrchat in one place.

[![Discord Banner](https://discordapp.com/api/guilds/948581245527425114/widget.png?style=banner3)](https://discord.gg/uhvsaEFmSE)


# Installation

1. Download ``VrcOscIntegrations.exe`` from <https://github.com/Killers0992/VrcOscIntegrations/releases/latest>
2. Launch downloaded exe and wait.
 ( everything is stored in My Documents/VrcOscIntegrations folder )
3. Goto tab ``Integrations Browser`` install integration which you want.
4. Installed application should be in ``My Integrations`` tab.
5. In box which contains your installed integration name click ``View`` to show user interface for this integration.

# Avaliable integrations

- Twitch Integration - Allows you to control avatar thru twitch ( chat commands, rewards, sub/follow events )
- Source: https://github.com/Killers0992/TwitchIntegration

# Configs

Main config ``config.yml`` for application can be found in MyDocuments -> VrcOscIntegrations.

If you want to configure stuff manually for installed integration goto to ``MyDocuments`` -> ``VrcOscIntegration`` -> ``Integrations`` -> ``<Integration Name>`` -> ``config.yml``

# Using VrcOscIntegration app for your osc apps.


Language ``C#``

Target framework ``net6.0-windows``


Used dependencies:

``ReaLTaiizor`` v3.7.8.5

``CoreOSC`` v1.0.0

Also if you want to use references from VRC OSC Integrations download required reference ``VrcOScIntegrations.dll`` from https://github.com/Killers0992/VrcOscIntegrations/releases/latest

Template project can be found there: https://github.com/Killers0992/TemplateIntegration

If your project is compiled you can take your dll and put in ``MyDocuments/VrcOscIntegrations/Integrations`` and then
restart application itself if you want to load your integration.
